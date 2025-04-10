using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using MyWebApi.Models;
using MyWebApi.Repositories;
using Xunit;

namespace MyWebApi.Tests.Repositories
{
    public class ParticipantRepositoryTests
    {
        [Fact]
        public async Task GetAllAsync_ShouldReturnMockedParticipants()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApiDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new ApiDbContext(options);

            // Ajouter des participants moqués dans la base de données en mémoire
            var mockedParticipants = new List<Participant>
            {
                new Participant { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Dupont", Email = "alice.dupont@example.com" },
                new Participant { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Martin", Email = "bob.martin@example.com" }
            };

            await context.Participants.AddRangeAsync(mockedParticipants);
            await context.SaveChangesAsync();

            var repository = new ParticipantRepository(context);

            // Act
            var result = await repository.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(mockedParticipants.Count, result.Count());
            Assert.Contains(result, p => p.FirstName == "Alice" && p.LastName == "Dupont");
            Assert.Contains(result, p => p.FirstName == "Bob" && p.LastName == "Martin");
        }

        [Fact]
        public async Task AddAndDeleteAsync_ShouldInsertAndRemoveParticipant()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApiDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new ApiDbContext(options);
            var repository = new ParticipantRepository(context);

            var newParticipant = new Participant
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "User",
                Email = "test.user@example.com",
                Company = "TestCompany",
                JobTitle = "Tester"
            };

            // Act - Add the participant
            await repository.AddAsync(newParticipant);

            // Assert - Verify the participant was added
            var addedParticipant = await context.Participants.FindAsync(newParticipant.Id);
            Assert.NotNull(addedParticipant);
            Assert.Equal("Test", addedParticipant.FirstName);
            Assert.Equal("User", addedParticipant.LastName);

            // Act - Delete the participant
            await repository.DeleteAsync(newParticipant);

            // Assert - Verify the participant was removed
            var deletedParticipant = await context.Participants.FindAsync(newParticipant.Id);
            Assert.Null(deletedParticipant);
        }
    }
}

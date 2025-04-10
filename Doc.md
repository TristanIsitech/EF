# Documentation technique - MyWebApi

## Description
**MyWebApi** est une API Web d�velopp�e avec **ASP.NET Core** et **Entity Framework Core**. Elle g�re des entit�s telles que les �v�nements, les participants, les lieux, et leurs relations. Ce document pr�sente les aspects techniques cl�s du projet.

---

## Pr�requis
- .NET 8.0 SDK
- MySQL (ou tout autre fournisseur de base de donn�es compatible avec EF Core)

---

## 1. **Technologies utilis�es**
- **.NET 8.0** : Framework principal pour le d�veloppement de l'API.
- **Entity Framework Core** : ORM utilis� pour g�rer les interactions avec la base de donn�es.
- **MySQL** : Base de donn�es relationnelle utilis�e pour stocker les donn�es.
- **Swagger** : G�n�ration automatique de la documentation de l'API.
- **xUnit** et **Moq** : Frameworks pour les tests unitaires et d'int�gration.

---

## 2. **Structure du projet**
- `Models/` : Contient les entit�s du mod�le de donn�es (Event, Participant, Location, etc.).
- `Repositories/` : G�re l'acc�s aux donn�es via Entity Framework Core.
- `Services/` : Contient la logique m�tier.
- `SeedData/` : Fournit des donn�es initiales pour la base de donn�es.
- `Configurations/` : Contient les configurations des entit�s pour Entity Framework Core.
- `Migrations/` : Contient les fichiers de migration g�n�r�s par Entity Framework Core.
- `Tests/` : Contient les tests unitaires et d'int�gration.

---

## 3. **Configuration de la base de donn�es**
La base de donn�es est configur�e dans le fichier `Program.cs` avec **MySQL** comme fournisseur.

---

## 4. **Donn�es seed�es**
Des donn�es initiales sont ins�r�es dans la base via **Fluent API** pour faciliter les tests et le d�veloppement.
Les donn�es initiales sont d�finies dans SeedData/EventSeedData.cs et ins�r�es via HasData dans ApiDbContextModelSnapshot.cs.

---

## 5. **Validation des donn�es**
Un filtre global est utilis� pour valider les mod�les envoy�s dans les requ�tes HTTP.

---

## 6. **Utilisation de LINQ**
Des requ�tes complexes sont effectu�es avec **LINQ** pour manipuler les donn�es.

---

## 7. **Tests**
Le projet inclut des tests pour garantir la fiabilit� des fonctionnalit�s.
Les tests unitaires utilisent **xUnit** et **InMemoryDatabase** pour simuler la base de donn�es.

---

## 8. **Swagger**
Swagger est configur� pour g�n�rer automatiquement la documentation de l'API.

---

## 9. **Relations entre entit�s**
Les relations entre les entit�s sont configur�es avec **Fluent API**.

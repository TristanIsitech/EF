# Documentation technique - MyWebApi

## Description
**MyWebApi** est une API Web développée avec **ASP.NET Core** et **Entity Framework Core**. Elle gère des entités telles que les événements, les participants, les lieux, et leurs relations. Ce document présente les aspects techniques clés du projet.

---

## Prérequis
- .NET 8.0 SDK
- MySQL (ou tout autre fournisseur de base de données compatible avec EF Core)

---

## 1. **Technologies utilisées**
- **.NET 8.0** : Framework principal pour le développement de l'API.
- **Entity Framework Core** : ORM utilisé pour gérer les interactions avec la base de données.
- **MySQL** : Base de données relationnelle utilisée pour stocker les données.
- **Swagger** : Génération automatique de la documentation de l'API.
- **xUnit** et **Moq** : Frameworks pour les tests unitaires et d'intégration.

---

## 2. **Structure du projet**
- `Models/` : Contient les entités du modèle de données (Event, Participant, Location, etc.).
- `Repositories/` : Gère l'accès aux données via Entity Framework Core.
- `Services/` : Contient la logique métier.
- `SeedData/` : Fournit des données initiales pour la base de données.
- `Configurations/` : Contient les configurations des entités pour Entity Framework Core.
- `Migrations/` : Contient les fichiers de migration générés par Entity Framework Core.
- `Tests/` : Contient les tests unitaires et d'intégration.

---

## 3. **Configuration de la base de données**
La base de données est configurée dans le fichier `Program.cs` avec **MySQL** comme fournisseur.

---

## 4. **Données seedées**
Des données initiales sont insérées dans la base via **Fluent API** pour faciliter les tests et le développement.
Les données initiales sont définies dans SeedData/EventSeedData.cs et insérées via HasData dans ApiDbContextModelSnapshot.cs.

---

## 5. **Validation des données**
Un filtre global est utilisé pour valider les modèles envoyés dans les requêtes HTTP.

---

## 6. **Utilisation de LINQ**
Des requêtes complexes sont effectuées avec **LINQ** pour manipuler les données.

---

## 7. **Tests**
Le projet inclut des tests pour garantir la fiabilité des fonctionnalités.
Les tests unitaires utilisent **xUnit** et **InMemoryDatabase** pour simuler la base de données.

---

## 8. **Swagger**
Swagger est configuré pour générer automatiquement la documentation de l'API.

---

## 9. **Relations entre entités**
Les relations entre les entités sont configurées avec **Fluent API**.

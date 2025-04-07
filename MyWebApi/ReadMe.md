# MyWebApi

## Description
Ce projet est une API Web utilisant ASP.NET Core et Entity Framework Core. Il inclut des entités pour les produits, les clients, les adresses et les commandes.

## Prérequis
- .NET 8.0 SDK
- MySQL (ou tout autre fournisseur de base de données compatible avec EF Core)

## Configuration de la base de données
Assurez-vous de configurer la chaîne de connexion à votre base de données dans le fichier `appsettings.json`.

## Commandes Entity Framework Core

### Ajouter une migration
Pour ajouter une nouvelle migration, utilisez la commande suivante :
`dotnet ef migrations add [NomDeLaMigration] --project MyWebApi -c ApiDbContext`

### Appliquer les migrations
Pour appliquer les migrations à la base de données, utilisez la commande suivante :
`dotnet ef database update --project MyWebApi -c ApiDbContext`

## Structure du projet
- `Models/` : Contient les entités du modèle de données.
- `Configurations/` : Contient les configurations des entités pour Entity Framework Core.
- `Migrations/` : Contient les fichiers de migration générés par Entity Framework Core.

## Contribuer
Les contributions sont les bienvenues ! Veuillez soumettre une pull request ou ouvrir une issue pour discuter des changements que vous souhaitez apporter.

## Licence
Ce projet est sous licence MIT. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

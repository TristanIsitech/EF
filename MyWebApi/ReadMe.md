# MyWebApi

## Description
Ce projet est une API Web utilisant ASP.NET Core et Entity Framework Core. Il inclut des entit�s pour les produits, les clients, les adresses et les commandes.

## Configuration de la base de donn�es
Assurez-vous de configurer la cha�ne de connexion � votre base de donn�es dans le fichier `appsettings.json`.

## Commandes Entity Framework Core

### Ajouter une migration
Pour ajouter une nouvelle migration, utilisez la commande suivante :
`dotnet ef migrations add [NomDeLaMigration] --project MyWebApi -c ApiDbContext`

### Appliquer les migrations
Pour appliquer les migrations � la base de donn�es, utilisez la commande suivante :
`dotnet ef database update --project MyWebApi -c ApiDbContext`

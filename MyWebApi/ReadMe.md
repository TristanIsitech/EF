# MyWebApi

## Description
Ce projet est une API Web utilisant ASP.NET Core et Entity Framework Core. Il inclut des entit�s pour les produits, les clients, les adresses et les commandes.

## Pr�requis
- .NET 8.0 SDK
- MySQL (ou tout autre fournisseur de base de donn�es compatible avec EF Core)

## Configuration de la base de donn�es
Assurez-vous de configurer la cha�ne de connexion � votre base de donn�es dans le fichier `appsettings.json`.

## Commandes Entity Framework Core

### Ajouter une migration
Pour ajouter une nouvelle migration, utilisez la commande suivante :
`dotnet ef migrations add [NomDeLaMigration] --project MyWebApi -c ApiDbContext`

### Appliquer les migrations
Pour appliquer les migrations � la base de donn�es, utilisez la commande suivante :
`dotnet ef database update --project MyWebApi -c ApiDbContext`

## Structure du projet
- `Models/` : Contient les entit�s du mod�le de donn�es.
- `Configurations/` : Contient les configurations des entit�s pour Entity Framework Core.
- `Migrations/` : Contient les fichiers de migration g�n�r�s par Entity Framework Core.

## Contribuer
Les contributions sont les bienvenues ! Veuillez soumettre une pull request ou ouvrir une issue pour discuter des changements que vous souhaitez apporter.

## Licence
Ce projet est sous licence MIT. Voir le fichier [LICENSE](LICENSE) pour plus de d�tails.

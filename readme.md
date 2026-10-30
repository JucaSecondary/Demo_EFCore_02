# Demo EFCore 02
Application ASP.NET MVC avec EFCore

## Choix technologiques pour la démo
- Monolithe en couche (WebApp + DAL)
- Utilisation de EFCore en Code-First

## Packages installés
### WebApp
  - Microsoft.EntityFrameworkCore.Design
Si non installé, lors de la création d'une migration, on reçoit le message d'erreur:
	```
	Your startup project 'Demo_EFCore_02' doesn't reference Microsoft.EntityFrameworkCore.Design.
	This package is required for the Entity Framework Core Tools to work.
	Ensure your startup project is correct, install the package, and try again.
	```

### DAL
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.SqlServer

## Migrations avec EFCore
### Solutions possibles
- ".NET CLI" avec _Microsoft.EntityFrameworkCore.Design_
  - Fonctionne partout
  - Necessite de configurer : `startup-project` et `project`
- "Package Manager Console" _(VS)_ avec _Microsoft.EntityFrameworkCore.Tools_
  - Simple à configurer

### Utilisation du .NET CLI
#### Installation de l'outil pour EFCore
```
dotnet tool install --global dotnet-ef
```

#### [Ajouter](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#dotnet-ef-migrations-add) une migration
Créer une nouvelle migration qui contient les méthodes `Up` et `Down`
```
dotnet ef migrations add <Nom de la migration>
```
>[!Note]
>Exemple depuis le dossier de la solution
>```
>dotnet ef migrations add <Nom de la migration> --project "<Chemin du projet DAL>" --startup-project "<Chemin du projet de démarrage>"
>```
#### [Supprimer](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#dotnet-ef-migrations-remove) la dernière migration
```
dotnet ef migrations remove
```
#### [Appliquer](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#dotnet-ef-database-update) une migration et MÀJ la BD
```
dotnet ef database update [specific_migration_name]
```
>[!Note]
>Exemple depuis le dossier de la solution
>```
>dotnet ef database update [Nom de la migration] --project "<Chemin du projet DAL>" --startup-project "<Chemin du projet de démarrage>"
>```
## Etapes effectuées
- Ajout des dossiers dans la DAL
- Ajout des packages
- Créer l'entité de la table à ajouter (PlayerEntity)
- Créer le DBContext et la configuration de l'entité (ne pas oublier de les appliquer)
	- Nom de la table
	- Clé primaire
	- Propriétés (colonnes de la tables dont l'ID)
	- Contraintes spécifiques dont unicité (avec index)
- Ajouter une migration
- Appliquer la migration
## Etapes à faire

- Ajouter le pattern repository dans la DAL pour préparer les méthodes CRUD
- S'occuper de la partie application
	- Créer les viewmodel
	- Créer les services
	- Créer le controlleur et utiliser le service
	- Créer le constructeur du contrôleur qui fait injection de dépendance
	- Générer les vues
- Repeat depuis `création de l'entité de la table à ajouter`
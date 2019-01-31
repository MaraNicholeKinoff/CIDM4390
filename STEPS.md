# Steps taken to finish assignment.

1. dotnet new mvc
2. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
3. dotnet tool install --global dotnet-aspnet-codegenerator
4. Create the Member.cs and Client.cs models.
5. dotnet aspnet-codegenerator controller -name MemberController -m Member -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
- This is scaffolding the Member.
6. dotnet aspnet-codegenerator controller -name ClientController -m Client -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
- This is scaffolding the Client
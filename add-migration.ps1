Write-Host "starting to create migrations"

dotnet ef migrations add "$args" --project ".\Data\Data.csproj" --startup-project ".\Console\Console.csproj" --context FirstLibraryContext
dotnet ef migrations add "$args" --project ".\Data\Data.csproj" --startup-project ".\Console\Console.csproj" --context SecondLibraryContext

Write-Host "done creating all migrations"
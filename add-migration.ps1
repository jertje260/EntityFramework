$PROJECT='".\Data\Data.csproj"'
$STARTUP='".\Console\Console.csproj"'

Write-Host "starting to create migrations"

dotnet ef migrations add "$args" --project $PROJECT --startup-project $STARTUP --context FirstLibraryContext
dotnet ef migrations add "$args" --project $PROJECT --startup-project $STARTUP --context SecondLibraryContext

Write-Host "done creating all migrations"
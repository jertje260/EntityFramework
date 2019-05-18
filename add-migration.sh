#!/usr/bin/env bash
PROJECT=".\Data\Data.csproj"
STARTUP=".\Console\Console.csproj"

PARAMS="--project $PROJECT --startup-project $STARTUP"
echo "starting to create migrations"

dotnet ef migrations add "$@" $PARAMS --context FirstLibraryContext
dotnet ef migrations add "$@" $PARAMS --context SecondLibraryContext

echo "done creating all migrations"
#!/usr/bin/env bash

echo "starting to create migrations"

dotnet ef migrations add "$@" --project ".\Data\Data.csproj" --startup-project ".\Console\Console.csproj" --context FirstLibraryContext
dotnet ef migrations add "$@" --project ".\Data\Data.csproj" --startup-project ".\Console\Console.csproj" --context SecondLibraryContext

echo "done creating all migrations"
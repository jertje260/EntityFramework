# Different Data sets

In some cases you would like to have the same database structure, but maybe different data in your seeds.

In this branch there is an example of how you could do it.

First we have the base context (`Context.cs`) which contains the basic structure of the database scheme. It has all the configurations for references between object, FK etc (things like indexes should also go in here)

Then we have two derived contexts (`FirstLibraryContext.cs` and `SecondLibraryContext.cs`) each of these have different configurations to add the seeding.

I have also added a script to create migrations for both contexts at the same time. That way it doesn't matter which context you are running, the latest created migration always has the same name.

The script can be ran with the command below:
```shell
# bash
add-migration.sh -name="migrationName" -startup="startupProject"

# powershell
add-migration.ps1 -name="migrationName" -startup="startupProject"
```
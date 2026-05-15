# PostgreSQLPlayground

## Run locally from Docker image

`docker run --name test-postgress -p 5432:5432 -e POSTGRES_PASSWORD=playgroundpass -d postgres:13.3`

PGAdmin


Create migration (for example from PackageManager console)
```
PM> add-migration Initial
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
```
Apply migration (all that haven't been applied before)
`PM> update-database`

Check PgAdmin
Applied migrations are stored in `__EFMigrationsHistory` table
<img width="1914" height="1124" alt="image" src="https://github.com/user-attachments/assets/b93c0e43-2979-4ecc-8adf-b05391baf1e5" />




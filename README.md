# PostgreSql Feature

## Jsonb

JSONB (JSON Binary) is a PostgreSQL data type that stores JSON documents in a binary format. Unlike the JSON type, it supports efficient indexing, fast querying, and a rich set of operators for searching and manipulating JSON data.

The main advantage of JSONB is its ability to store flexible, evolving data structures without requiring frequent database schema changes, while still allowing efficient queries against individual document fields.

## Concurrency


## MVCC

Get transaction id
`SELECT txid_current();`

`SELECT * FROM heap_page_items(get_raw_page('t',0))` (firstly install exception `CREATE EXTENSION IF NOT EXISTS pageinspect;`)`



## Run locally from Docker image

`docker run --name test-postgress -p 5432:5432 -e POSTGRES_PASSWORD=playgroundpass -d postgres:13.3`

Visual Studio

Create migration (for example from PackageManager console)
```
PM> add-migration Initial
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
```
Apply migration (all that haven't been applied before)
`PM> update-database`

PGAdmin

Check PgAdmin
Applied migrations are stored in `__EFMigrationsHistory` table
<img width="1914" height="1124" alt="image" src="https://github.com/user-attachments/assets/b93c0e43-2979-4ecc-8adf-b05391baf1e5" />










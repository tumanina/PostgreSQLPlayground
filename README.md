# PostgreSql Features

## Jsonb

JSONB (JSON Binary) is a PostgreSQL data type that stores JSON documents in a binary format. Unlike the JSON type, it supports efficient indexing, fast querying, and a rich set of operators for searching and manipulating JSON data.

The main advantage of JSONB is its ability to store flexible, evolving data structures without requiring frequent database schema changes, while still allowing efficient queries against individual document fields.

<img width="925" height="384" alt="image" src="https://github.com/user-attachments/assets/28bcc444-8659-4996-8792-389d8b5bc87f" />

`DeploymentHistory.Where(d => d.Settings.Kafka.Topic == topic)`

<img width="925" height="399" alt="image" src="https://github.com/user-attachments/assets/d0195fcf-a010-440f-9071-b2a8194295d5" />


## Concurrency

### Optimistic Concurrency (xmin)

PostgreSQL provides optimistic concurrency through the system column xmin, which is automatically updated every time a row is modified. EF Core can use xmin as a concurrency token, including it in the WHERE clause of UPDATE statements. If another transaction has already modified the row, the update affects zero rows and EF Core throws a DbUpdateConcurrencyException.

<img width="674" height="320" alt="image" src="https://github.com/user-attachments/assets/b974b969-fe46-4c48-a7e7-3419d3f7d708" />

### Pessimistic Concurrency (FOR UPDATE)

Pessimistic concurrency prevents conflicts by locking rows before they are modified. PostgreSQL provides this through SELECT ... FOR UPDATE, ensuring that selected rows cannot be updated by other transactions until the current transaction completes. 
Additional options such as NOWAIT (fail immediately if the row is locked) and SKIP LOCKED (skip locked rows instead of waiting) make it ideal for scalable work queues, Inbox/Outbox implementations, and distributed background workers.

### LISTEN / NOTIFY

PostgreSQL's LISTEN/NOTIFY provides a lightweight publish/subscribe mechanism that allows applications to receive real-time notifications without polling the database. 
It is commonly used to wake up background workers or notify services that new data is available, reducing unnecessary database queries. Since notifications are not persisted or guaranteed, they are typically used as a signal to query the database rather than as a reliable messaging system.

<img width="672" height="350" alt="image" src="https://github.com/user-attachments/assets/dbbdf8f4-9a42-4674-bdff-f85694d18b75" />


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










# First Entity Project

## Packages

```
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.11
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.11

```

## Connection String 

```
Host=localhost;Port=5432;Username=postgres;Password=******;Database=dbname
```


## Migrations 
```
dotnet ef migrations add First -o Data/Migrations
dotnet ef database update

```

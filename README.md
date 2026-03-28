# Shipping Order Service

## Description
The Shipping Order Service is a learning project built to put several concepts into practice (some still to be implemented):
- **Domain-Driven Design (DDD)**
- **Authentication & Authorization**
- **Cloud-first Solutions**
- **AI Integration**

It is a .NET Web API built to manage shipping orders within the Smart Logistics domain. It provides a robust backend utilizing PostgreSQL, Entity Framework Core, Keycloak for identity and access management, and Ulid. It is configured for easy local development using Docker Compose.

## Tech Overview
- **Framework:** .NET 10.0
- **Database:** PostgreSQL (via Npgsql)
- **ORM:** Entity Framework Core 10.0 (with NamingConventions)
- **IAM:** Keycloak (Identity and Access Management)
- **Validation:** FluentValidation
- **IDs:** Ulid
- **Containerization:** Docker & Docker Compose

## Prerequisites
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Docker](https://www.docker.com/) and Docker Compose
- `make` (for running Makefile commands)

## Installation
1. Clone the repository.
2. Restore the project dependencies by running:
   ```bash
   make restore
   ```

## Running the Application
To run the project locally, start the required dependencies and then the API:

1. **Start the database and Keycloak containers:**
   ```bash
   make docker-up
   ```
2. **Apply Entity Framework Core database migrations:**
   ```bash
   make update-db
   ```
3. **Run the API:**
   ```bash
   make run
   ```
   *(To run with hot-reload enabled, use `make watch` instead)*

## Useful Commands
The root `Makefile` provides helpful commands to manage the project. 

- `make all`             - Restore, clean, and build the solution
- `make clean`           - Clean build artifacts
- `make reset`           - Clean build artifacts and delete `bin`/`obj` directories
- `make restore`         - Restore NuGet packages
- `make build`           - Build the solution
- `make run`             - Run the API
- `make watch`           - Run the API with hot reload
- `make test`            - Run unit tests
- `make test-coverage`   - Run tests and generate a coverage report
- `make add-migration NAME=MigrationName` - Create a new EF Core migration
- `make update-db`       - Apply migrations to the database
- `make drop-db`         - Drop the database
- `make reset-db`        - Drop and recreate the database
- `make publish`         - Publish the project in the Release configuration
- `make docker-up`       - Start Docker dependencies (PostgreSQL, Keycloak)
- `make docker-down`     - Stop Docker containers
- `make docker-reset`    - Reset Docker volumes and restart dependencies

PROJECT_FILE = ./src/ShippingOrderService.Web/ShippingOrderService.Web.csproj
TEST_PROJECT_FILE = ./src/ShippingOrderService.Tests/ShippingOrderService.Tests.csproj
SOLUTION_FILE = ./src/ShippingOrderService.slnx
PUBLISH_DIR = ./build

NAME ?= Migration
CONFIG ?= Release

all: restore clean build

clean:
	@echo "Cleaning project..."
	dotnet clean $(SOLUTION_FILE)

reset:clean
	@echo "Removing bin and obj directories..."
	find . -type d -name "bin" ! -path "./.git/*" -exec rm -rf {} +
	find . -type d -name "obj" ! -path "./.git/*" -exec rm -rf {} +

restore:
	@echo "Restoring dependencies..."
	dotnet restore $(SOLUTION_FILE)

build: restore
	@echo "Building project..."
	dotnet build $(SOLUTION_FILE) --no-restore

run:
	@echo "Running project..."
	dotnet run --project $(PROJECT_FILE)

watch:
	@echo "Running project with hot reload..."
	dotnet watch --project $(PROJECT_FILE)

test:
	@echo "Running tests..."
	dotnet test $(TEST_PROJECT_FILE) --no-build --logger "console;verbosity=normal"

test-coverage:
	@echo "Running tests with coverage..."
	dotnet test $(TEST_PROJECT_FILE) \
		--collect:"XPlat Code Coverage" \
		--results-directory ./coverage

add-migration:
	@echo "Creating EF migration: $(NAME)..."
	dotnet ef migrations add $(NAME) --project $(PROJECT_FILE)

update-db:
	@echo "Running database migrations..."
	dotnet ef database update --project $(PROJECT_FILE)

drop-db:
	@echo "Dropping database..."
	dotnet ef database drop --force --project $(PROJECT_FILE)

reset-db: drop-db update-db
	@echo "Database reset complete."

publish: clean build
	@echo "Publishing project to $(PUBLISH_DIR)..."
	dotnet publish $(PROJECT_FILE) -c $(CONFIG) -o $(PUBLISH_DIR) --no-restore

docker-up:
	@echo "Starting dependencies..."
	docker compose up -d

docker-down:
	@echo "Stopping dependencies..."
	docker compose down

docker-reset:
	@echo "Resetting docker volumes..."
	docker compose down -v
	docker compose up -d

help:
	@echo ""
	@echo "Available targets:"
	@echo "  make all             - restore, clean and build"
	@echo "  make clean           - clean build artifacts"
	@echo "  make reset           - clean build artifacts and delete bin/obj dirs"
	@echo "  make restore         - restore NuGet packages"
	@echo "  make build           - build the solution"
	@echo "  make run             - run the API"
	@echo "  make watch           - run with hot reload"
	@echo "  make test            - run tests"
	@echo "  make test-coverage   - run tests with coverage report"
	@echo "  make add-migration NAME=MigrationName"
	@echo "  make update-db       - apply migrations"
	@echo "  make drop-db         - drop the database"
	@echo "  make reset-db        - drop and recreate the database"
	@echo "  make publish         - publish in Release"
	@echo "  make docker-up       - start docker dependencies"
	@echo "  make docker-down     - stop docker containers"
	@echo "  make docker-reset    - reset docker volumes"
	@echo ""

.PHONY: all clean reset restore build run watch test test-coverage publish \
        add-migration update-db drop-db reset-db \
        docker-up docker-down docker-reset help
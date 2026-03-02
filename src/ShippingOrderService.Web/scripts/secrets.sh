# scripts/setup-secrets.sh
#!/bin/bash
echo "Configuring local secrets..."

read -p "Connection String: " conn
dotnet user-secrets set "ConnectionStrings:Default" "$conn"

echo "Secrets configurados."

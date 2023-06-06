$timestamp = Get-Date -Format "yyyymmddHHmmss"

dotnet ef migrations script --idempotent --project infrastructure -o "infrastructure/migrations/scripts/$timestamp.sql"

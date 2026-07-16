#!/bin/bash
set -e

export ASPNETCORE_URLS="http://0.0.0.0:${PORT:-8080}"

echo "Starting .NET application..."
exec dotnet Presentation.dll

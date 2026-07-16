#!/bin/bash
set -e

MYSQL_ROOT_PASSWORD="1234567890"
MYSQL_DATABASE="RanchMasterDB"

if [ ! -d "/var/lib/mysql/mysql" ]; then
    echo "Initializing MySQL data directory..."
    mysqld --initialize-insecure --user=mysql
fi

mysqld --user=mysql &
MYSQL_PID=$!

echo "Waiting for MySQL to start..."
for i in $(seq 1 30); do
    if mysqladmin ping --silent 2>/dev/null; then
        echo "MySQL is ready."
        break
    fi
    if [ $i -eq 30 ]; then
        echo "MySQL failed to start."
        exit 1
    fi
    sleep 1
done

mysql -u root -e "ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY '${MYSQL_ROOT_PASSWORD}'; FLUSH PRIVILEGES;" 2>/dev/null || \
mysql -u root -e "CREATE USER IF NOT EXISTS 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY '${MYSQL_ROOT_PASSWORD}'; GRANT ALL PRIVILEGES ON *.* TO 'root'@'localhost' WITH GRANT OPTION; FLUSH PRIVILEGES;" 2>/dev/null

mysql -u root -p${MYSQL_ROOT_PASSWORD} -e "CREATE DATABASE IF NOT EXISTS ${MYSQL_DATABASE};"

export ASPNETCORE_URLS="http://0.0.0.0:${PORT:-8080}"

echo "Starting .NET application..."
exec dotnet Presentation.dll

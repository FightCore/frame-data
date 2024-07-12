FROM mcr.microsoft.com/mssql/server:2019-latest
ENV MSSQL_SA_PASSWORD=yourStrong(!)Password
ENV ACCEPT_EULA=Y

COPY --chown=mssql:root framedata.bak /var/opt/mssql/data/framedata.bak

COPY --chown=mssql:root restore-database.sql restore-database.sql

RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Starting database restore" && /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'yourStrong(!)Password' -d master -i restore-database.sql
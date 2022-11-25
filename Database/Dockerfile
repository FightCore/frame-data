FROM mcr.microsoft.com/mssql/server:2019-CU18-ubuntu-20.04

RUN mkdir -p /opt/scripts
COPY framedata.sql /opt/scripts

ENV MSSQL_SA_PASSWORD=Passw@rd
ENV ACCEPT_EULA=Y

EXPOSE 1433

RUN /opt/mssql/bin/sqlservr --accept-eula & sleep 30  & /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'Passw@rd' -d master -i /opt/scripts/framedata.sql
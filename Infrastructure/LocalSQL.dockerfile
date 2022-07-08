# If you want your own mssql with hookers and gambling
FROM mcr.microsoft.com/mssql/server:2019-latest
# Switch to root user for access to apt-get install
USER root
# Update image packages because we like living on the edge
RUN apt-get -y update

WORKDIR /setup-server

COPY entrypoint.sh .
COPY setup.sh .
COPY setup.sql .

# Grant permissions to execute setup.sh
RUN chmod +x setup.sh

EXPOSE 1433

# Switch back to mssql user and run the entrypoint script
USER mssql
ENTRYPOINT /bin/bash ./entrypoint.sh
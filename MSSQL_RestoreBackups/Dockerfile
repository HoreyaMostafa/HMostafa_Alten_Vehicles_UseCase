FROM microsoft/mssql-server-linux:2017-latest

#Copying database dump and shell scripts
COPY dbbackups/backups /var/backups/
COPY restore-database.sh /usr/src
COPY start.sh /usr/src

#changing directory to run scripts
WORKDIR /usr/src

#giving execute permission to db script
RUN chmod +x start.sh restore-customers-database.sh

#exposing sql server port
EXPOSE 1433

#setting required environment variables
ENV SA_PASSWORD=Alten1234
ENV ACCEPT_EULA=Y

#starting sql server
CMD [ "start.sh" ]
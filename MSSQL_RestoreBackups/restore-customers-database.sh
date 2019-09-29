#!/bin/bash


#waiting for the SQL Server to come up
echo "Waiting SQL server starting up ........."
sleep 20

while :
do
    #checking if Dev db exists or not then restore it if it doesn't exists
    echo "Checking Dev Database in SQL server ........."
    CustomersDBExists=$(/opt/mssql-tools/bin/sqlcmd -S 127.0.0.1 -U SA -P $SA_PASSWORD -Q "IF DB_ID('Dev') IS NOT NULL print 'EXISTS' ELSE print 'NOT_EXISTS'")

    if [[ "$CustomersDBExists" == "EXISTS" ]]; then
        echo "Customers DB exists!!"
        break
    elif [[ "$CustomersDBExists" == "NOT_EXISTS" ]]; then
        echo "Customers DB doesn't exists!!"
        echo "Starting to restore Customers database ......."

        #running the setup script to restore Dev DB
        /opt/mssql-tools/bin/sqlcmd -S 127.0.0.1 -U SA -P $SA_PASSWORD -Q 'RESTORE DATABASE CustomersDB FROM DISK = "/var/backups/customers.bak" 

        echo "CustomersDB database restored successfully!"
        break
    else
        echo "Unknown error, retry again!!"
        sleep 2
    fi
done
exit

#!/bin/bash

#restoring Customers database into sql server
/usr/src/restore-customers-database.sh &

#starting sql server
/opt/mssql/bin/sqlservr

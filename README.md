# Setup and Run
Run Visual Studio and Docker Desktop as Admin

Pull down SQL server image for demo - Run command in Windows Terminal
 docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=myStrong(!)Password" -p 1433:1433 --name sql_server_arksoft -d mcr.microsoft.com/mssql/server:2019-latest

Code will run initial start up script to seed data for demo

launch solution via docker
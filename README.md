# Alten Vehicles Monitoring Challenge


## Solution Architecture:

![alt text](https://github.com/HoreyaMostafa/HMostafa_Alten_Vehicles_UseCase/blob/master/Diagrams/SolutionDiagram.png)

------------------------
## Solution Details:

| Component			  | Test						| Dockerized | UnitTesting |Tech
| :--------------|:---------------:					| -----:| -----:|-----:|
| Customers APIs      | http://localhost:5001/api/customer |Y|Y| .Net core WebAPI
| Vehicles APIs     |All Vehicles>http://localhost:5000/api/vehicle	Connected_Vs>http://localhost:5000/api/vehicle/true	Disconncted_Vs>http://localhost:5000/api/vehicle/false	Customer_Vs>http://localhost:5000/api/vehicle/{CustomerID} | Y | X | .Net core WebAPI
| Vehicles Ping API |   http://localhost:5002/api/vehicle/Ping/:VIN	|Y|X | .Net core ConsoleAPP
| Vehicles Monitoring Web Protal | http://localhost:5003|X|X| Angular7

## Technologies, Patterns & Tools:

- Vistual Studio 2017
- SQL Server - Express
- Dot Net Core Web API
- DP-->  Repositry Design Patterns
- SPA --> Angular 7
- Unit testing -->  Xunit
- CI --> Travis
- Repo --> GitHub
- Containerization: Docker


## Serverless/Cloud Solution Architecture - AWS Based:

![alt text](https://github.com/HoreyaMostafa/HMostafa_Alten_Vehicles_UseCase/blob/master/Diagrams/Solution_Serverless_AWSCloud_BasedDiagram.png)

## Deployment steps:


## Future Work

- Implement the serverless design on AWS free tier.
- Presist/Log all Vehicles Ping History.
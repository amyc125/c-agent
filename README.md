# EventsMonitor
This is an agent to collect windows event logs for the kafka producer and a consumer that consumes the event logs from the lafla topic. 

## Intsall dotnet 6.0
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## Run Docker and set up project 
run docker-compose up -d
run dotnet restore

## Run consumer 
Go to consumer directory (EVENTS/consumer) and run the command "dotnet run"

## Run producer 
Go to consumer directory (EVENTS/producer) and run the command "dotnet run"

## Kafka GUI
This is the UI to view the kafka cluster and messages being sent to the kafka topic 
localhost:9000
#   c - a g e n t  
 
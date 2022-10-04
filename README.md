# Asignment 2 - system integration
To run this project you need Microsoft Visual Studio and Docker.
first of, start docker and run our two containers in the Redis and Postgres directory:
```
Docker\Postgres
docker-compose up -d
Docker\Redis
docker-compose up -d
```
- Now setup multiple projects to start: microservice1 and subscriberConsole.
- Run the project
- Use the swagger interface, to send a request to microservice1
- Microservice1 publishes the request-data to a Redis queue, which our subsciberConsole is subscribed to
- Check your postgres-DB. The complaint is saved in the database, together with an email of the sender

We've used an extensive amount of time to try and integrate camunda in the .NET Framework to no avail. Therefore our assignment isn't as fleshed out, as we would have wanted it to be...

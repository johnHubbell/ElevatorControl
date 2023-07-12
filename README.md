# REST API Elevator Control

Before running a project you should First Download [DotNetCore6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) and install it.

## Install Dependencies

    dotnet restore

## Build and Run the app

    dotnet build
    dotnet run 

# REST API

This project has swagger OpenAPI and Postman Collection that you can download it from this [link](https://github.com/johnHubbell/ElevatorControl/blob/JohnHubbell/feat/ElevatorControlFunc/Elevaror%20Control.postman_collection.json)

## Add Destination

Add a new Destination that can be from a person in the Elevator Car or out of the elevator car are in the floors

### Request

`Post`

**Input param:** floorNumber (int)

    https://localhost:7086/api/Elevator/AddDestination

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 2
    
    []

## Get Current Floor

### Request

`Get`

It returns the current floor of the Elevator Car

**Input param:** ---

    https://localhost:7086/api/Elevator/GetCurrentFloor

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 2
    
    {0}

## Get Elevator Direction

### Request

Return to the direction of the elevator 

`GET`

    https://localhost:7086/api/Elevator/GetElevatorDirection

### Response

Return The Enum by number

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 2
    
    {0}

## Get The Next Destination Floor

Return the floor number of the next destination of the elevator

### Request

`GET`

    https://localhost:7086/api/Elevator/GetNextDestionationFloor

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:30 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 2
    
    {1}
    
    



 

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 74
    
    [{"id":1,"name":"Foo","status":"new"},{"id":2,"name":"Bar","status":null}]

## 

### 

`PUT /thing/:id/status/changed`

    curl -i -H 'Accept: application/json' -X PUT http://localhost:7000/thing/1/status/changed

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40
    
    {"id":1,"name":"Foo","status":"changed"}

## 

### 

`GET /thing/id`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40
    
    {"id":1,"name":"Foo","status":"changed"}

## 

### 

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'name=Foo&status=changed2' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41
    
    {"id":1,"name":"Foo","status":"changed2"}

## 

### Request

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'status=changed3' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41
    
    {"id":1,"name":"Foo","status":"changed3"}

## 

### Request

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'id=99&status=changed4' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41
    
    {"id":1,"name":"Foo","status":"changed4"}

## 

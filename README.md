# Description
ExamApp is a backend application developed to manage exam results and enable real-time video streaming for monitoring during exams. The goal is to provide a secure and reliable environment for conducting online exams with live monitoring using two cameras, ensuring that videos are not stored due to data protection concerns.

## Technologies Used
### ASP.NET Core: 
  Framework for building the backend.
### Entity Framework Core: 
  ORM for managing database access.
### SignalR and Azure SignalR: 
  For real-time video streaming.
### SQL Server: 
  Database for storing exam results.
### C#: 
  Programming language used for the project.

## Implemented Features
### Storing Exam Results:

Implemented endpoints to submit and retrieve exam results.
Used Entity Framework Core to interact with the SQL Server database.

## Real-Time Video Streaming:

Configured SignalR to enable real-time video streaming during exams.
Used Azure SignalR to scale real-time streaming without storing videos.

## Project Structure
```lua

/ExamApp
|-- /Controllers
|   |-- ExamController.cs
|   |-- VideoHub.cs
|-- /Models
|   |-- ExamResult.cs
|   |-- ExamSubmission.cs
|-- /Services
|   |-- ExamService.cs
|-- Program.cs
|-- Startup.cs
|-- appsettings.json

```
## Learnings
During the development of this project, I learned several important lessons, including:

## Entity Framework Core Configuration:

Creating and configuring DbContext to interact with the SQL Server database.
Creating and applying migrations to update the database schema.

## Using SignalR for Real-Time Communication:

Configuring SignalR and Azure SignalR for real-time video streaming.
Integrating SignalR with ASP.NET Core to manage real-time connections.

## Managing Dependencies and Packages:

Adding and managing necessary NuGet packages for the project.
Resolving dependency issues and version compatibility problems.

## Configuring and Deploying Cloud Services:

Utilizing Azure services to scale the application and manage real-time streaming.

## Instructions for Execution

Clone the Repository

```bash

git clone https://github.com/fiborges/ExamApp.git
cd ExamApp
```
## Restore Dependencies

```bash

dotnet restore
```
## Apply Migrations and Update Database

```bash

dotnet ef migrations add InitialCreate
dotnet ef database update

```
## Run the Application

```bash

dotnet run
```

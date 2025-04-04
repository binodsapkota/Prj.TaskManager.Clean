# 🏗️ Task Manager API - Clean Architecture in ASP.NET Core  

This is a **Task Manager API** built using **ASP.NET Core** following the **Clean Architecture** principles.  
It provides a structured, scalable, and maintainable architecture for building robust web applications.  

## 📌 Architecture Overview  

This project is organized into four layers:  
/TaskManagerApp 
├── /Core → (Business Entities & Interfaces) 
│ ├── /Entities → Domain models (Task, User, etc.) 
│ ├── /Interfaces → Repository & Service contracts 
│ ├── /DTOs → Data Transfer Objects 
├── /Application → (Business Logic Layer) 
│ ├── /Services → Implements use cases (TaskService, UserService) 
│ ├── /Features → Handles commands & queries 
├── /Infrastructure → (Database, External APIs, Third-Party Integrations) 
│ ├── /Persistence → EF Core DbContext & Repository Implementations 
│ ├── /Identity → Authentication & Authorization 
├── /Presentation → (Controllers, Views, UI) 
│ ├── /API → ASP.NET Core Web API Controllers 
│ ├── /MVC → MVC Controllers & Views (if needed) 
├── /Shared → (Common Utilities, Exception Handling) 
├── /Tests → (Unit & Integration Tests) 
├── TaskManager.sln → Solution file

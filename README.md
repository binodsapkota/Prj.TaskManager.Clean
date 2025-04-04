# 🏗️ Task Manager API - Clean Architecture in ASP.NET Core  

This is a **Task Manager API** built using **ASP.NET Core** following the **Clean Architecture** principles.  
It provides a structured, scalable, and maintainable architecture for building robust web applications.  

## 📌 Architecture Overview  

📂 Project Structure Explained

1️⃣ Core (Domain Layer)
Defines Entities (Task, User, etc.)

Contains Interfaces for repositories and services

No dependencies on other layers

2️⃣ Application Layer
Implements business logic

Contains services and use cases

Calls repositories but does NOT directly interact with the database

3️⃣ Infrastructure Layer
Implements database access (EF Core)

Handles third-party services (Email, Payment, Logging, etc.)

4️⃣ Presentation Layer (API & UI)
Contains Controllers for handling HTTP requests

Web API built using ASP.NET Core

Could include an MVC UI

## 🚀 Features  

✅ **Clean Architecture** – Domain, Application, Infrastructure, and Presentation separation.  
✅ **Entity Framework Core** – Code-first approach with repository pattern.  
✅ **Dependency Injection** – Uses built-in DI container for loose coupling.  
✅ **JWT Authentication** – Secured endpoints using JSON Web Tokens.  
✅ **Unit Testing** – Separate test projects for service and repository testing.  

---

## 🛠️ Getting Started  

### 🔹 Prerequisites  
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
- SQL Server (LocalDB or other instance)  
- Visual Studio 2022 / VS Code  

### 🔹 Installation Steps  

#### 1️⃣ **Clone the Repository**
```sh
git clone https://github.com/yourusername/TaskManagerAPI.git
cd TaskManagerAPI



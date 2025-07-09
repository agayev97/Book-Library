BookLibrary is a .NET-based library management system designed with Clean Architecture principles. It uses Entity Framework Core for data access and runs on SQL Server.

  **Features**
-  Book management (CRUD operations)
-  User management (members and librarians)
-  Book rental and return functionality
-  **Clean Architecture** structure
-  SQL Server support with **Entity Framework Core**
-  Implementation of **Dependency Injection (DI)**
-  **ASP.NET Core Web API**


  **Technologies**
This project uses the following technologies:
-   **ASP.NET Core**
-   **Entity Framework Core**
-   **AutoMapper**
-   **Dependency Injection**
-   **Swagger UI**
-   **SQL Server**

  
-  **Project Structure**
    BookLibrary/
│── BookLibrary.Domain/       # Domain models (Entities)
│── BookLibrary.Application/  # Business logic (Services, Use‑Cases)
│── BookLibrary.Infrastructure/ # Data access layer & Repositories
│── BookLibrary.API/          # Controllers
│── README.md                 # Project overview

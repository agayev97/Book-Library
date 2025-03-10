BookLibrary, kitabxana idarəetmə sistemi üçün nəzərdə tutulmuş bir .NET layihəsidir. Bu layihə **Clean Architecture** prinsiplərinə əsaslanır və **Entity Framework Core** istifadə edərək SQL Server-də işləyir.

  **Xüsusiyyətlər**
-  Kitabların idarə olunması (CRUD)
-  İstifadəçilər (üzvlər, kitabxanaçılar) ilə işləmə
-  Kitab icarəsi və qaytarılması
-  **Clean Architecture** strukturu
-  **Entity Framework Core** ilə SQL Server dəstəyi
-  **Dependency Injection (DI)** tətbiqi
-  **ASP.NET Core Web API**


  **Texnologiyalar**
Bu layihə aşağıdakı texnologiyalardan istifadə edir:
-   **ASP.NET Core**
-   **Entity Framework Core**
-   **AutoMapper**
-   **Dependency Injection**
-   **Swagger UI**
-   **SQL Server**

  
-  **Layihə Strukturu**
    BookLibrary/
│── BookLibrary.Domain/       # Domen modelləri (Entities)
│── BookLibrary.Application/  # Biznes qaydaları (Services, Use Cases)
│── BookLibrary.Infrastructure/ # Məlumat bazası və Repository-lər
│── BookLibrary.API/          # Web API və controller-lər
│── README.md                 # Layihə haqqında məlumat

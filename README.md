# 🚀 N-Layer Architecture with .NET 9 & Gemini AI Integration

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![EF Core](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Gemini AI](https://img.shields.io/badge/Google%20Gemini-8E75B2?style=for-the-badge&logo=google&logoColor=white)
![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)
![License](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)

## 📖 Proje Hakkında

Bu proje, **N-Katmanlı Mimari (N-Layer Architecture)** prensiplerine tam uyumluluk gösteren, ölçeklenebilir ve modüler bir yapıda geliştirilmiş kapsamlı bir **.NET çözümüdür**. Hem RESTful API hem de MVC UI katmanlarını içerir.

Modern yazılım geliştirme pratikleri, **Clean Code** prensipleri ve **Google Gemini AI** entegrasyonu ile güçlendirilmiştir. Klasör yapısından veritabanı işlemlerine kadar her detay titizlikle yapılandırılmıştır.

---

## 🏗️ Mimari ve Teknik Özellikler

Proje, sürdürülebilirlik ve performans odaklı aşağıdaki teknolojiler ve desenlerle geliştirilmiştir:

### ⚙️ Core & Altyapı
* **📂 N-Katmanlı Mimari:** Core, Data, Service, API ve WebUI katmanları arasında gevşek bağımlılık (Loose Coupling).
* **🛠️ Scrutor:** Dependency Injection süreçlerini otomatize etmek ve kod tekrarını önlemek için assembly tarama.
* **🔄 Generic Repository Design Pattern:** Veri erişim katmanında kod tekrarını önleyen jenerik yapılar.
* **📦 UnitOfWork Pattern:** (API Tarafında) Transaction yönetimi ve veri bütünlüğü için merkezi yönetim.

### 🔐 Güvenlik ve Kimlik Doğrulama
* **🔑 Identity & JWT:** API güvenliği için JSON Web Token, UI tarafı için Identity kütüphanesi.
* **🛡️ DTO (Data Transfer Objects):** `Record` tipleri kullanılarak **Immutable** (değiştirilemez) ve güvenli veri taşıma.

### 🤖 Yapay Zeka & Entegrasyonlar
* **✨ Google Gemini AI:** Proje içerisine entegre edilmiş yapay zeka servisi.

### 🎨 UI & Frontend (MVC)
* **🧩 ViewComponents:** Tekrar kullanılabilir, modüler UI parçacıkları.
* **📑 Areas:** Yönetim paneli (Admin) ve Kullanıcı arayüzü ayrımı için Area yapısı.
* **📝 Admin CRUD:** Yönetim panelinde tam yetkili veri yönetim işlemleri.

### 💾 Veri ve Entity Framework
* **🕵️ AuditDbContextInterceptor:** `SaveChanges` öncesi araya girerek **CreatedDate** ve **UpdatedDate** alanlarını otomatik dolduran mekanizma.
* **🗄️ Entity Framework Core:** Code-First yaklaşımı ile veritabanı yönetimi.

---

## 📂 Proje Yapısı

Klasörleme mantığı, SOLID prensiplerine hizmet edecek şekilde düzenlenmiştir:

```text
AITech.Solution
│   ├── 📂 AITech.Entity
│   │   ├── 📂 Common (BaseEntity, IEntity, IAuditEntity)
│   │   └── 📂 Concrete (Product, Category, User vb.)
│   │
│   └── 📂 AITech.DTO
│       └── 📂 DTOS (Immutable Record Tipleri)
│           ├── ProductDto.cs
│           └── UserDto.cs
│
│   ├── 📂 AITech.DataAccess (EF Core & Repositories)
│   │   ├── 📂 Contexts (AppDbContext)
│   │   ├── 📂 Interceptors (AuditDbContextInterceptor.cs) 👈 Created/Updated Tarihleri
│   │   ├── 📂 Configurations (Fluent API ayarları)
│   │   ├── 📂 Migrations
│   │   ├── 📂 Repositories (Generic & Concrete Repositories)
│   │   └── 📂 UnitOfWork (API için transaction yönetimi)
│   │
│   └── 📂 AITech.Integrations (Dış Servisler)
│       └── 📂 GeminiAI (Gemini Entegrasyon kodları)
│
│   └── 📂 AITech.Business
│       ├── 📂 Abstract (IService Interface'leri)
│       ├── 📂 Concrete (Service Manager'ları)
│       ├── 📂 Mappings (AutoMapper Profilleri)
│       ├── 📂 Validations (FluentValidation Kuralları)
│       └── 📂 DependencyResolvers (Scrutor Extensions) 👈 Otomatik DI tarama
│
│   ├── 📂 AITech.API (Restful Servis)
│   │   ├── 📂 Controllers
│   │   ├── 📂 Filters
│   │   └── 📂 Middleware (Global Exception Handling)
│   │
│   └── 📂 AITech.WebUI (MVC Arayüz)
│       ├── 📂 Areas
│       │   └── 📂 Admin 👈 Admin Paneli buraya
│       │       ├── Controllers
│       │       └── Views
│       ├── 📂 ViewComponents 👈 Widgetlar buraya
│       ├── 📂 Views
│       ├── 📂 wwwroot
│       └── Program.cs

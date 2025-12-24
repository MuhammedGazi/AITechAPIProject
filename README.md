<div align="center">

  <img src="https://media.giphy.com/media/qgQUggAC3Pfv687qPC/giphy.gif" width="120" />

  # 🚀 Modern .NET Architecture & AITechAPIProject

  <p align="center">
    <b>N-Katmanlı Mimari | Google Gemini AI | Identity & JWT | Advanced Patterns</b>
  </p>

  ![.Net](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
  ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
  ![EF Core](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)
  ![Google Gemini](https://img.shields.io/badge/Google%20Gemini-8E75B2?style=for-the-badge&logo=googlebard&logoColor=white)
  ![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)

  <br>

  <a href="#-proje-hakkında">Proje Hakkında</a> •
  <a href="#-teknik-özellikler">Teknik Özellikler</a> •
  <a href="#-mimari-yapı">Mimari</a> •
  <a href="#-kurulum">Kurulum</a>

</div>

---

## 🌟 Proje Hakkında

Bu proje, modern yazılım geliştirme prensiplerini (**SOLID, Clean Architecture**) temel alarak geliştirilmiş kapsamlı bir **Full-Stack .NET** uygulamasıdır. 

Proje hem **API** servislerini hem de **MVC UI** arayüzünü tek bir çatı altında, ancak tamamen izole edilmiş katmanlarla sunar. **Google Gemini** entegrasyonu ile yapay zeka destekli özellikler barındırır ve **Admin/UI** ayrımı `Areas` yapısı ile kusursuzca sağlanmıştır.

---

## 🏗️ Mimari Yapı & Klasör Düzeni
Proje, gevşek bağlı (loosely coupled) bir yapı için **N-Katmanlı Mimari (N-Tier)** kullanılarak tasarlanmıştır.

```mermaid
graph TD;
    Core[Core Layer] --> Data[Data Layer];
    Data --> Service[Service Layer];
    Service --> API[API Presentation];
    Service --> MVC[MVC Web UI]

Proje, gevşek bağlı (loosely coupled) bir yapı için **N-Katmanlı Mimari (N-Tier)** kullanılarak tasarlanmıştır.
📂 Core Layer: Varlıklar (Entities), DTOs (Records), Interface'ler.
📂 Data Layer: EF Core konfigürasyonları, Repository Pattern, UnitOfWork.
📂 Service Layer: İş mantığı (Business Logic), Validasyonlar, Mapping.
📂 Presentation (API & Web): Controller'lar, View'ler, ViewComponent'ler.
🔥 Teknik Özellikler ve Yetenekler
🛡️ Güvenlik & Kimlik (Security & Identity)ÖzellikAçıklama.NET IdentityKullanıcı kayıt, giriş ve rol yönetimi.JWT (JSON Web Token)API tarafında güvenli ve ölçeklenebilir yetkilendirme.Secure DTOsVeriler record tipleri kullanılarak immutable (değiştirilemez) şekilde taşınır.
⚙️ Backend & Veritabanı (Backend & DB)ÖzellikAçıklamaUnitOfWork PatternTüm veritabanı işlemlerinin tek bir transaction ile yönetilmesi.Generic RepositoryKod tekrarını önleyen, merkezi veri erişim metotları.AuditDbContextInterceptorCreatedDate ve UpdatedDate alanlarının EF Core seviyesinde otomatik yönetilmesi.ScrutorDependency Injection (DI) tanımlamalarının otomatik taranıp register edilmesi (Clean Program.cs).
🎨 Frontend & UI (MVC)ÖzellikAçıklamaAreas YapılanmasıAdmin ve UI panellerinin fiziksel ve mantıksal olarak ayrılması.View ComponentsTekrar eden UI parçalarının modüler hale getirilmesi.Admin CRUDTam teşekküllü yönetim paneli işlemleri.
🤖 Yapay Zeka (AI Integration)Google Gemini Entegrasyonu: Proje içerisinde içerik üretimi veya veri analizi için Google'ın güçlü LLM modeli Gemini entegre edilmiştir.

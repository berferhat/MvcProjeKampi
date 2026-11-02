# MvcProjeKampi

Murat Yücedağ'ın YouTube **MVC Proje Kampı** eğitimini izleyerek yaptığım ASP.NET MVC 5 projesi.

Eğitim: [MVC Proje Kampı playlist](https://www.youtube.com/watch?v=yFToRUL6h8A&list=PLKnjBHu2xXNNQJehhCg--CzQQMHXTsFAb)

Sözlük / blog tarzı bir uygulama. Vitrin, yazar paneli ve admin paneli var.

---

## Neler yaptım?

- Solution'ı 4 katmana ayırdım: EntityLayer, DataAccessLayer, BusinessLayer, MvcProjeKampi
- Entity Framework 6 Code First ile entity'leri ve ilişkileri yazdım
- Migration ile `DbMvcKamp` veritabanını oluşturdum
- Generic Repository ve DAL sınıflarını yazdım
- Business katmanında Manager sınıflarını yazdım
- FluentValidation kurallarını ekledim
- AdminLTE ile admin panelini kurdum
- Kategori, başlık, yazar, içerik, hakkımızda, iletişim, mesaj, galeri ve rapor ekranlarını yaptım
- Yazar paneli: login, profil, başlık, içerik, mesaj
- Vitrin tarafını yaptım
- Forms Authentication ve rol (A / B) ekledim
- Admin giriş ve rol işlemlerini AdminManager'a taşıdım
- Session ile yazara göre veri getirdim

---

## Neler öğrendim?

- ASP.NET MVC 5
- Katmanlı mimari
- Entity Framework Code First
- Migration
- Repository Pattern
- FluentValidation
- Forms Authentication
- RoleProvider
- Session
- AdminLTE tema kullanımı
- CRUD işlemleri

---

## Kullanılan teknolojiler

- ASP.NET MVC 5
- .NET Framework 4.8
- Entity Framework 6
- MSSQL Server
- FluentValidation
- AdminLTE 3
- Bootstrap
- jQuery
- LINQ

---

## Klasör yapısı

```
MvcProjeKampi/
├── EntityLayer/
├── DataAccessLayer/
├── BusinessLayer/
└── MvcProjeKampi/
```

---

## Çalıştırma

1. Repoyu klonla
2. `MvcProjeKampi.sln` dosyasını Visual Studio ile aç
3. NuGet Restore
4. `MvcProjeKampi/Web.config` içindeki connection string'i düzenle:

```xml
<add name="Context"
     connectionString="data source=localhost;initial catalog=DbMvcKamp;integrated security=true;"
     providerName="System.Data.SqlClient" />
```

5. Package Manager Console:
   - Default project: `DataAccessLayer`
   - Startup project: `MvcProjeKampi`

```powershell
Update-Database
```

6. F5 ile çalıştır

Giriş:
- Admin: `/Login/Index`
- Yazar: `/Login/WriterLogin`

---

## Teşekkür

Murat Yücedağ — MVC Proje Kampı

# MvcProjeKampi

Murat Yücedağ'ın YouTube'daki **MVC Proje Kampı** eğitimini (yaklaşık 100 video) izleyerek yaptığım ASP.NET MVC 5 projesi.

Eğitim: [MVC Proje Kampı playlist](https://www.youtube.com/watch?v=yFToRUL6h8A&list=PLKnjBHu2xXNNQJehhCg--CzQQMHXTsFAb)

---

## Proje özeti

Sözlük / blog tarzı bir uygulama. Üç tarafı var:

- **Vitrin:** başlık ve içerikleri gezme
- **Yazar paneli:** giriş, profil, başlık, içerik, mesaj
- **Admin paneli:** kategori, başlık, yazar, içerik, iletişim, galeri, rapor

---

## Neler yaptım?

### Katmanlar
- Solution'ı 4 parçaya ayırdım: `EntityLayer`, `DataAccessLayer`, `BusinessLayer`, `MvcProjeKampi`
- Referans yönünü buna göre kurdum: UI → Business → DAL → Entity

### Veritabanı
- Entity Framework 6 Code First
- Entity'ler: Category, Heading, Content, Writer, About, Contact, Message, ImageFile, Admin
- İlişkileri (FK / navigation property) tanımladım
- Migration ile `DbMvcKamp` veritabanını oluşturup güncelledim

### Repository / Business
- Generic Repository + entity DAL sınıfları
- Manager sınıflarıyla iş mantığını controller'dan ayırdım
- FluentValidation (kategori, yazar, mesaj, iletişim)

### Admin paneli
- AdminLTE entegrasyonu
- Kategori, başlık, yazar, hakkımızda, mesaj/iletişim, galeri, rapor ekranları
- Başlık listesi ve rapor sayfası

### Yazar paneli
- Yazar login
- Profil, başlık ve içerik işlemleri
- Gelen / giden mesajlar
- Session ile giriş yapan yazara göre veri getirme

### Login ve yetki
- Forms Authentication
- Global Authorize
- Admin / yazar için ayrı login
- Admin rollerinde A / B ayrımı
- Admin giriş ve rol okumayı `AdminManager` üzerinden yaptım

### Diğer
- 404 sayfası
- Galeri (`ImageFile`)
- Grafik ekranı
- Vitrin tarafı (`Default`, `HomePage`)

---

## Bu süreçte gördüğüm konular

- ASP.NET MVC 5 (Controller, View, Layout, Partial)
- Katmanlı mimari
- EF Code First + Migration
- Repository Pattern
- FluentValidation
- Session
- Forms Authentication / RoleProvider
- AdminLTE tema bağlama
- CRUD işlemleri

---

## Teknolojiler

- ASP.NET MVC 5
- .NET Framework 4.8
- Entity Framework 6
- MSSQL Server
- FluentValidation
- AdminLTE 3, Bootstrap, jQuery
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
4. `MvcProjeKampi/Web.config` içindeki connection string'i kendi SQL Server'ına göre düzenle:

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

### Giriş
- Admin: `/Login/Index`
- Yazar: `/Login/WriterLogin`

Eğitim projesi olduğu için şifreler şu an düz metin.

---

## Teşekkür

Murat Yücedağ — MVC Proje Kampı

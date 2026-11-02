# MvcProjeKampi

Murat Yücedağ'ın YouTube'daki **MVC Proje Kampı** eğitimini (yaklaşık 100 video) izleyerek adım adım yazdığım ASP.NET MVC projesidir.

Amaç basit: ekranda görünen bir site yapmak değil; katmanlı mimari, Entity Framework, repository, validation, login ve panel tarafını gerçekten kurup çalıştırmak. Bu yüzden proje hem öğrenme kaydı hem de portföy örneği olarak duruyor.

Eğitim kanalı: [Murat Yücedağ](https://www.youtube.com/watch?v=yFToRUL6h8A&list=PLKnjBHu2xXNNQJehhCg--CzQQMHXTsFAb)

---

## Proje ne işe yarıyor?

Sözlük / blog tarzı bir web uygulaması:

- Ziyaretçi vitrinde başlıkları ve yazıları gezebiliyor
- Yazarlar giriş yapıp başlık açabiliyor, içerik yazabiliyor, mesajlaşabiliyor
- Admin panelinden kategori, başlık, yazar, içerik, iletişim, galeri ve raporlar yönetiliyor

Yani tek sayfalık demo değil; admin + yazar + vitrin olarak üç tarafı olan bir uygulama.

---

## Bu projede neler yaptım?

### Mimari
- Solution'ı 4 katmana ayırdım: **EntityLayer**, **DataAccessLayer**, **BusinessLayer**, **MvcProjeKampi (UI)**
- Üst katman alt katmanı tanıyacak şekilde referansları kurdum
- Entity katmanını bağımsız bıraktım (hiçbir projeye bağımlı değil)

### Veri tarafı
- Entity Framework 6 **Code First** ile çalıştım
- `Category`, `Heading`, `Content`, `Writer`, `About`, `Contact`, `Message`, `ImageFile`, `Admin` entity'lerini yazdım
- Primary key, foreign key, navigation property ilişkilerini kurdum
- SQL Server'da `DbMvcKamp` veritabanını migration ile oluşturdum / güncelledim
- Cascade hatası gibi gerçekçi sorunlarla uğraşıp çözdüm

### Repository ve Business
- Generic Repository + entity bazlı DAL sınıfları yazdım
- Business katmanında Manager sınıflarıyla iş kurallarını UI'dan ayırdım
- FluentValidation ile kategori, yazar, mesaj, iletişim gibi formlarda kurallar tanımladım

### Admin paneli
- AdminLTE temasını projeye entegre ettim
- Kategori, başlık, yazar, hakkımızda, iletişim/mesaj, galeri, rapor ekranlarını yaptım
- Başlık listesinde kategoriye göre badge renkleri kullandım
- Heading raporu sayfasını ekledim

### Yazar paneli
- Yazar login
- Profil düzenleme
- Kendi başlıklarımı yönetme
- Tüm başlıklara içerik ekleme
- Gelen / giden mesajlar
- Session ile oturumdaki yazara göre veri filtreleme

### Güvenlik ve yetki
- Forms Authentication
- Proje genelinde Authorize
- Admin ve yazar için ayrı login sayfaları
- Admin rollerinde A / B ayrımı
- Rol okuma ve admin girişini Business katmanına taşıdım (`AdminManager`)

### Diğer
- 404 hata sayfası
- Galeri (ImageFile tablosundan)
- Google Chart ile grafik ekranı
- Vitrin / sözlük tarafı (`Default`, `HomePage`)

---

## Bu projede öğrendiklerim

Bunlar teoride kalmadı; projede kullandım:

- ASP.NET MVC 5 (Controller, View, Layout, Partial View)
- N-Tier / katmanlı mimari neden var, referans yönü nasıl olmalı
- Entity Framework Code First + Migration
- Repository Pattern ve generic yapı
- FluentValidation
- Session ve Forms Authentication
- RoleProvider ile rol kontrolü
- AdminLTE gibi hazır temayı kendi projene bağlamak
- Admin / yazar paneli ayrımı
- CRUD işlemlerini uçtan uca yazmak
- Connection string, DbContext, migration akışı

Kısaca: “MVC biliyorum” demekten ziyade, katmanlı bir MVC projesini baştan kurup ilerletebildiğimi göstermek için uygun bir örnek.

---

## Teknolojiler

- ASP.NET MVC 5
- .NET Framework 4.8
- Entity Framework 6 (Code First)
- MSSQL Server
- FluentValidation
- Repository Pattern
- AdminLTE 3 / Bootstrap / jQuery
- LINQ

---

## Proje yapısı

```
MvcProjeKampi/
├── EntityLayer/         # Modeller
├── DataAccessLayer/     # Context, Repository, Migrations
├── BusinessLayer/       # Manager + Validation
└── MvcProjeKampi/       # Controllers, Views, Web.config
```

Akış:

`UI → Business → Data Access → Entity → SQL Server`

---

## Kurulum

1. Repoyu klonla
2. `MvcProjeKampi.sln` dosyasını Visual Studio ile aç
3. NuGet Restore yap
4. `MvcProjeKampi/Web.config` içindeki connection string'i kendi SQL Server'ına göre düzenle:

```xml
<add name="Context"
     connectionString="data source=localhost;initial catalog=DbMvcKamp;integrated security=true;"
     providerName="System.Data.SqlClient" />
```

5. Package Manager Console'da:
   - Default project: **DataAccessLayer**
   - Startup project: **MvcProjeKampi**

```powershell
Update-Database
```

6. Projeyi çalıştır (F5)

### Giriş adresleri
- Admin: `/Login/Index`
- Yazar: `/Login/WriterLogin`

Not: Eğitim projesi olduğu için şifreler şu an düz metin tutuluyor. Canlı bir sistemde hash kullanılır.

---

## Şu anki durum

Projenin ana iskeleti ve panelleri çalışıyor. Kursun ilerleyen konularına göre grafiklerin veritabanına bağlanması, istatistik ekranı, SweetAlert, şifre hash gibi adımlar eklenebilir / eklenecek.

Yani “her şeyi bitirdim, production hazır” demiyorum. Ama mimari kurulmuş, paneller açılmış, login-rol-mesaj-galeri-rapor tarafı ilerletilmiş bir MVC kamp projesi.

---

## Neden portföyde dursun?

- Sadece HTML/CSS değil, gerçek katmanlı backend mantığı var
- Entity ilişkileri, migration, repository, validation, auth gibi konular bir arada
- Admin ve yazar gibi iki farklı kullanıcı senaryosu düşünülmüş
- Eğitim videosunu kopyalayıp bırakmak yerine kendi ortamımda ayağa kaldırıp ilerlettim

İnceleyen biri dosya yapısına bakınca ne yaptığımı net görebilir.

---

## Teşekkür

Murat Yücedağ — MVC Proje Kampı eğitimi için.

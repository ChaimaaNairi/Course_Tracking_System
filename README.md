# Ders Takip Sistemi
Ders Takip Sistemi, Bilgisayar Mühendisliği Fakültesi yüksek lisans ve doktora öğrencilerinin ders kayıtlarını takip etmek amacıyla tasarlanmış bir yazılım projesidir.

<h2>Kullanıcı Arayüz Tasarımı </h2>

**Loading Ekranı ve Ana Sayfa:** Ana sayfa, Ders Takip Sistemi'nin kullanıcıların karşılaştığı ilk sayfadır. 
<b>Loading Ekranı:</b>
Loading ekranı, kullanıcının beklemesini engelleyerek sistemin yüklenme sürecini gösteren bir ekran tasarımıdır.

<b>Ana Sayfa:</b>
Ana sayfa üzerinde bir navigasyon çubuğu (navbar) bulunmalıdır.
Navbar, kullanıcılara ana sayfa, duyurular, etkinlikler, hakkında gibi sekmeleri seçme imkanı sunar.
Giriş yapma işlemi  için "Giriş" butonu vardır.

**Giriş Sayfasi:** Giriş sayfasında kullanıcılar, numara ve şifrelerini girerek sisteme giriş yapabilirler. Ayrıca, iki seçenek bulunmalıdır: "Öğrenci" ve "Öğretmen". Kullanıcılar, kendi rol ve yetkilerine göre ilgili seçeneği seçerek giriş yapabilirler. Giriş işlemini tamamlamak için "Giriş" butonu bulunmalıdır. Bu sayede kullanıcılar doğru kimlik bilgilerini girerek ilgili kullanıcı hesabına erişebilirler.

**Öğrenci Arayuzu:** Öğrenci arayüzünde, öğrencinin kişisel bilgileri yer alır. Bu bölümde, öğrencinin adı, numarası, bölümü ve diğer önemli bilgileri görüntülenir. 
Ders seçme bölümü, öğrencinin derslerini seçmesini sağlar. Bu bölümde, öğrenciye sunulan ders listesi gösterilir ve öğrenci istediği dersleri seçerek kaydolabilir.

**Öğretmen Arayuzu:** Öğretmen arayüzünde, öğretmenin kişisel bilgileri bulunur. Bu bölümde, öğretmenin adı, numarası, bölümü ve diğer önemli bilgileri görüntülenir. Ayrıca, öğretmenin verdiği derslerin bir listesi sunulur.
Verdiği dersler listesi bölümü, öğretmenin hangi dersleri verdiğini gösterir. Bu bölümde, öğretmenin dersleri ve ilgili bilgileri, ders adı, kodu, saatleri vb.
Ders aldığı öğrenciler listesi bölümü, öğretmenin hangi öğrencilerin dersine kayıtlı olduğunu gösterir.


<h2>Veri Tabanı Tasarımı</h2>

+ Veritabanı, PostgreSQL veritabanı yönetim sistemi ve pgAdmin4 grafik kullanıcı arayüzü kullanılarak tasarlandı.

+ **Öğrenci giriş tablosu:** öğrenci id, kullanıcı adı ve şifre alanlarını içerir. 

+ **Öğrenci bilgileri tablosu :** Ad soyad , cinsiyet, bölüm, öğrenci id, dönem alanlarını içerir. 

+ **Dönem dersleri tablosu:** Dönem, ders id , ders adı, gün id, saat, öğretmen bilgilerini içerir. 

+ **Öğretim görevlisi giriş tablosu:** Kullanıcı adı, öğretim üyesi id, şifre bilgilerini içerir. 

+ **Öğretim görevlisi bilgileri tablosu:** ad soyad, cinsiyet, öğretmen bilgilerini içerir. 

+ **Dersi alan öğrenciler tablosu:** Kullanıcı adı, ders id, dönem bilgilerini içerir. 

+ **Ders tablosu:** Öğretim üyesi id, dersin adı, dersin kredisi, ders id, saat id, dönem id, gün id, ders türü bilgilerini içerir.



<h2>Backend Tasarımı</h2>











# Ders Takip Sistemi
Ders Takip Sistemi, Bilgisayar Mühendisliği Fakültesi yüksek lisans ve doktora öğrencilerinin ders kayıtlarını takip etmek amacıyla tasarlanmış bir yazılım projesidir.

<h2>Kullanıcı Arayüz Tasarımı </h2>

**Kullanıcı Girişi:** Kullanıcıların sisteme giriş yapması ve hesaplarına erişim sağlaması için kullanılır. Kullanıcı, kullanıcı adı ve şifresini girerek sisteme giriş yapabilir.

**Ders Kaydı:** Kullanıcılar, mevcut dersler arasından seçim yaparak derslere kaydolabilirler. Bu use case, öğrencilerin ders seçme işlemlerini ve öğretmenlerin dersleri oluşturma ve güncelleme işlemlerini kapsar.

**Ders Programını Görüntüleme:** Kullanıcılar, kayıtlı oldukları derslerin programını görüntüleyebilirler. Bu use case, kullanıcıların ders saatlerini, sınıflarını ve öğretim görevlilerini görmelerine olanak tanır.

**Not Girişi:** Öğretmenler, öğrencilerin performansını değerlendirmek için not girişi yapabilirler. Bu use case, öğretmenlerin öğrencilerin sınav sonuçlarını, ödev notlarını veya proje puanlarını sisteme kaydetmelerini içerir.

**Akademik İlerlemeyi Görüntüleme:** Kullanıcılar, akademik ilerlemelerini kontrol etmek için notlarını ve ders geçme durumlarını görüntüleyebilirler. Bu use case, kullanıcılara derslerdeki performanslarını takip etme imkanı sunar.


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











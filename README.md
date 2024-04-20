Proje bir Sinema salonu seans takip uygulamasıdır. Proje c# da windows form olarak tek bir ana form üzerine yapılmış, veritabanı olarak SQLite kullanılmıştır.

4 adet model dosyamız bulunmakta:
Filmler: Bu kısımda Filmler hakkındaki özellikler bulunmakta.

Musteri: bu kısımda sinema bileti alımı için kullanıcıdan alınan ödeme bilgileri bulunmakta.

Seanslar: bu kısımda seçilen filmler için databasedaki seans tarihleri, saatleri ve sinema salonları bulunmakta.

SinemaSalon: bu kısımda databasede hazır bulunan sinema salonları ve kapasiteleri yer almakta.

DBContext.cs: bu kısım Entity Framework core veritabanı bölümüdür. Bu kısımda Sqlite ile yazılan veritabanıyla bağlantı oluşturan yapıdır. Filmler, Musteri, Seanslar ve Sinemasalonu verilerine erişim sağlar.

Film Seçim Ekranı: Açılan ilk bu ekranda veritabanına film, 4 seans saati ile eklenip tabloda görüntülenebilir.

Salon Seçim Ekranı: bu kısımda sinema salonları salon ismi ve kapasiteleri yazılıp veritabanına kayedilebilir ve ekranda görüntülenir.

Seans Seçim Ekranı: bu ekranda film adı, salon adı, tarih ve saat girilip veritabanına kayedilir ve tabloda görüntülenir.

Ödeme Ekranı: Bu kısımda ise ekranda bulunan daha önce kaydedilen Film, salon adı tarih ve saat bulunur. İstenilen film seçildikten sonra kullanıcıdan alınan ad, soyad, kimlik no, kart no, son kullanma tarihi ve cvc kodu ile bilet oluşturulup veritabanına kaydedilir.

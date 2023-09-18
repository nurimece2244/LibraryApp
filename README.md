# LibraryApp

Bu uygulama, kullanıcıların kitapları ödünç almasını sağlar. Aynı zamanda bir yönetici arayüzüne sahip olup, yöneticilerin kitap envanterini görüntülemelerine, yeni kitaplar eklemelerine ve kitapların ödünç durumunu izlemelerine olanak tanır.

**Özellikler**
Kitap Listeleme Ekranı: Admin kullanıcısı, tüm kitapları bu ekranda görüntüleyebilir. Kitabın adı, yazarı ve mevcut olup olmadığı bu ekranda listelenir.

**Ödünç Durumu:** Bir kitap şu anda kütüphanede mevcutsa, bir "Ödünç Ver" butonu aktif olur. Eğer kitap ödünç alındıysa, bu kitabın hangi kullanıcıda olduğu bilgisi gösterilir.

**Yeni Kitap Ekleme:** Admin, yeni kitapları sistem envanterine ekleyebilir.

**Kullanım**
Admin kullanıcısı sisteme giriş yapar.
Kitap listeleme ekranında mevcut kitapların listesini görüntüler.
Bir kitap kütüphanede mevcutsa, ödünç verme işlemi için "Ödünç Ver" butonunu kullanabilir.
Ödünç alınan kitaplar için kullanıcı bilgisi görüntülenir.
Yeni kitap eklemek için ilgili bölüme gidilir ve kitap bilgileri girilerek envantere eklenir.

**Kurulum ve Başlangıç**
**Önkoşullar:**
.NET Core SDK (Önerilen sürüm: 7.0.11)

Projeye gerekli olan NuGet paketlerini kurmak için aşağıdaki komutları terminal veya komut satırında çalıştırın:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Pomelo.EntityFrameworkCore.MySql

https://localhost:44398/ adresine giderek uygulamayı çalıştırın.



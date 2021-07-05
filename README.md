# Mvc5 İle Blog Projesi

Projeme https://mvcminiblog.me/ sitesinden ulaşabilirsiniz.

Merhaba, bu proje genel olarak katmanlı mimariye uygun bir şekilde tasarlanmıştır . OOP olarak Entity Framework kullanılmaktadır .

## Kullanılan Araçlar & Alt Yapılar & Teknolojiler

- Migrations
- Katmanlı Mimari
- Entity Framework
- MVC Pattern

MvcBlogProject içerisinde bulununan MvcBlogProject katmanının içerisinde bulunun Web.config dosyasından connectionString içerisine kullanılacak veritabanı türünün ayarları ve bağlantı cümlesi yapılmalıdır.

![Screen Shot 6 06 2021 at 13 06](https://user-images.githubusercontent.com/63123956/120920672-a04b9980-c6c8-11eb-8ab0-7421a3f3a188.png)

Projemizde 3 adet panel bulunmaktadır . Bu pannelerden birincisi Vitrin herkesin kullanımına açık olan kısmımız ikincisi ise yazar panelimiz üçüncüsü ise Admin panelimizdir .

Ana sayfada ilk olarak öne çıkan postlar bizi karşılıyor . Menüde gördüğümüz bazı kategorilere daha hızlı bir erişim sağlanması adına bu kategorilerilere giden linkler verdik . Gidilen bu sayfada ise filtreleme ile sadece o kategoriye ait postlar karşımıza çıkmaktadır .

![Screen Shot 6 06 2021 at 13 16](https://user-images.githubusercontent.com/63123956/120920834-7ba3f180-c6c9-11eb-8a7e-f54157e7ba80.png)

Biraz aşağıya indiğimizde PagedList kullanarak sayfalama sistemi kullanarak oluşturduğumuz Postlarımızı görüyoruz . Postlarımıza tıkladığımızda detaylı inceleme fırsatı bulduğumuz bir sayfaya yönlendiriliyoruz .

![Screen Shot 6 06 2021 at 12 50 - 2](https://user-images.githubusercontent.com/63123956/120920959-0edd2700-c6ca-11eb-9ff3-33a43b372aeb.png)

Hemen aşağı kısmında da mail bültenimiz ve footer'ımız bulunmaktadır .

![Screen Shot 6 06 2021 at 13 25](https://user-images.githubusercontent.com/63123956/120921077-a2aef300-c6ca-11eb-8f03-81ce57041c9b.png)

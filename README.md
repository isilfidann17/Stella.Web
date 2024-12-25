# Stella Güzellik Salonu Uygulaması

**Stella**, bir güzellik salonu işletim sistemi olup, güzellik salonlarının yönetim ihtiyaçlarına yönelik kapsamlı bir çözüm sunmayı amaçlar. Bu uygulama, kullanıcıların salon çalışanlarından uygun işlemler için randevu alabilmesini ve çalışanların çalışma planlarını kolayca yönetmesini sağlar.

## Proje Hakkında

Bu proje, **ASP.NET Core MVC 6** frameworkü ve **PostgreSQL** veritabanı ile geliştirilmiştir. Proje dört katmandan oluşmaktadır:
- **Entity Layer**: Veri modellerinin tanımlandığı katman.
- **Data Access Layer**: Veritabanı işlemlerinin gerçekleştirildiği katman.
- **Business Layer**: İş kurallarının uygulandığı katman.
- **Presentation Layer**: Kullanıcı arayüzünün yer aldığı ana katman.

Proje, güzellik salonları için işlemleri, çalışanları ve randevu süreçlerini yönetme özelliklerini içermektedir.

## Özellikler

1. **Kuaför ve Güzellik Salonu Tanımlamaları**:
   - Salon çalışma saatleri, işlemleri, süre ve ücretlerini detaylı şekilde tanımlama.

2. **Çalışan Yönetimi**:
   - Çalışan uzmanlık alanları ve uygunluk saatlerinin yönetimi.

3. **Randevu Sistemi**:
   - Kullanıcıların uygun çalışanlardan randevu alabilmesi.
   - Randevu uygunluk kontrolleri.

4. **REST API Entegrasyonu**:
   - Bazı işlemler REST API üzerinden gerçekleştirilir.

5. **Yapay Zeka Entegrasyonu** *(Geliştirilecek)*:
   - Kullanıcıların fotoğraf yükleyerek saç modeli veya renk önerileri alması.

## Teknolojiler

- **Backend**: ASP.NET Core MVC 6, C#
- **Veritabanı**: PostgreSQL, Entity Framework Core ORM
- **Frontend**: Bootstrap, HTML5, CSS3, JavaScript, jQuery

## Kurulum

1. Bu depoyu yerel makinenize klonlayın:
   ```bash
   git clone https://github.com/kullanici-adi/stella.git

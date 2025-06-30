# Çiçekçi Yönetim Sistemi

Bu proje, bir çiçekçi dükkanının ürün, müşteri ve satış işlemlerini kolayca yönetebilmesi için geliştirilmiştir.

## Kurulum ve Çalıştırma

1. **Gereksinimler**
   - .NET Framework (veya .NET Core/5+)
   - MySQL Server (veya SQLite, kullandığın veritabanına göre)
   - MySQL.Data kütüphanesi (veya SQLite.Data)

2. **Veritabanı Kurulumu**
   - MySQL Workbench veya komut satırında aşağıdaki komutları çalıştırın:
     ```sql
     CREATE DATABASE IF NOT EXISTS CicekciDB;
     USE CicekciDB;
     -- Tablo ve prosedür SQL'lerini ekleyin
     ```
   - Gerekli tabloları ve saklı yordamları oluşturun.

3. **Projeyi Çalıştırma**
   - Projeyi Visual Studio ile açın veya komut satırında:
     ```
     msbuild
     ```
   - `App.config` veya bağlantı ayarlarında veritabanı bilgilerini güncelleyin.
   - Uygulamayı başlatın.

## Özellikler

- Ürün ekleme, güncelleme, silme
- Müşteri ekleme, güncelleme, silme
- Satış yapma ve satış tarihi kaydı
- Satışları listeleme

## Notlar

- Proje dosyaları ve kod yapısı hakkında detaylı bilgi için videolu anlatımı izleyebilirsiniz.
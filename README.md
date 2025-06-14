

# 🔒 LOGINFORM

## Genel Bakış

LOGINFORM, C# ve .NET Framework ile geliştirilmiş, temel kullanıcı giriş (login) işlemlerini gerçekleştirmek için tasarlanmış bir masaüstü uygulamasıdır. Kullanıcı kimlik doğrulama, şifre kontrolü ve güvenli oturum açma işlemleri için sade ve modern bir Windows Forms arayüzü sunar.

---

## Özellikler

- Kullanıcı adı ve şifre ile giriş
- Basit ve anlaşılır kullanıcı arayüzü
- Hatalı giriş uyarıları ve doğrulama mekanizması
- Modern uygulama ikonu 

---

## Teknik Altyapı

| Katman/Yapı        | Açıklama                                       |
|--------------------|------------------------------------------------|
| **Platform**       | .NET Framework                                 |
| **Arayüz**         | Windows Forms                                  |
| **Proje Dosyası**  | `LoginForm.csproj` veya benzeri                |
| **Ana Klasörler**  | `Class/`, `Forms/`, `Properties/`              |
| **Yapılandırma**   | `App.config`                                   |
| **İkon**           | `icons8_login.ico`                             |

### Temel Dosya ve Dizinler

```
LOGINFORM/
│
├── LoginForm.csproj
├── App.config
├── icons8_login.ico
├── Program.cs
├── packages.config
│
├── Class/          # Yardımcı ve iş mantığı sınıfları
├── Forms/          # Arayüz ve form dosyaları
├── Properties/     # Assembly, kaynaklar ve ayarlar
├── bin/            # Derlenmiş dosyalar
├── obj/            # Geçici derleme dosyaları
├── .vs/            # Visual Studio ayar dizini
```
> Not: Dosya yapısı örnektir; tam liste için [GitHub'dan inceleyebilirsiniz](https://github.com/dogukankosan/LOGINFORM/tree/main).

---

## Kurulum & Kullanım

1. Repoyu indir veya klonla.
2. Visual Studio ile aç.
3. Gerekiyorsa NuGet bağımlılıklarını yükle.
4. Projeyi derle ve çalıştır.
5. Kayıtlı kullanıcı adı ve şifreyle giriş yapabilirsin.

---

## Katkı Sağlama

Katkıda bulunmak için repoyu forklayabilir ve pull request gönderebilirsin.

---

## Lisans

MIT Lisansı ile sunulmuştur.

---

<p align="center">
  <img src="https://img.shields.io/badge/.NET-Framework-blue?logo=dotnet" alt="dotnet" />
  <img src="https://img.shields.io/badge/Windows%20Forms-UI-lightgrey" alt="winforms" />
</p>

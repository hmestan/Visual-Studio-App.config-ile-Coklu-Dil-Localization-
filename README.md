# Visual Studio App.config ile Çoklu Dil (Localization) Örneği

Bu proje, Windows Forms uygulamasında `app.config` dosyasını kullanarak dinamik dil değiştirme (Localization) işlemini göstermektedir. Kullanıcı, uygulamayı çalıştırırken istediği dili (Türkçe veya İngilizce) seçebilir.

## 🚀 Özellikler

- `app.config` dosyası üzerinden dil ayarlarını değiştirme
- Çalışırken (runtime) dil değiştirme desteği
- Kolay yapılandırma
- Windows Forms arayüzü

## 💻 Kullanım

1. Projeyi Visual Studio'da açın.
2. `app.config` dosyasındaki `<language>` kısmını güncelleyin:
3. Kullanılabilir diller: en (İngilizce), ru (Rusça), fr (Fransızca)
   ```xml
   <appSettings>
     <add key="language" value="tr"/>
   </appSettings>

## 📺 YouTube Videoları
- [Visual Studio App.Config ve Çoklu Dil Uygulaması](https://youtu.be/eicaeS8QDtY)  

---

## 📄 **README.md (English)**

# Multi-Language Example with Visual Studio App.config

This project demonstrates how to implement dynamic language change (localization) in a Windows Forms application using the `app.config` file. The user can choose the language (Turkish or English) while running the application.

## 🚀 Features

- Change language via `app.config`
- Runtime language switching support
- Easy to configure
- Windows Forms interface

## 💻 Usage

1. Open the project in Visual Studio.
2. Update the `<language>` setting in the `app.config` file:
3. Available languages: en (English), ru (Russian), fr (French)
   ```xml
   <appSettings>
     <add key="language" value="en"/>
   </appSettings>

## 📺 YouTube Videos
- [Visual Studio App.Config and Multi-Language Application](https://youtu.be/eicaeS8QDtY)  
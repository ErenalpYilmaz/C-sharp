# C# Console Uygulaması - Temel İşlemler

Bu, temel giriş işlemleri ve aritmetik operatörleri gösteren basit bir C# console uygulamasıdır.

## 📌 Özellikler
- Kullanıcıdan adını ve yaşını alan interaktif giriş işlemi.
- Değişkenler kullanılarak temel aritmetik işlemleri gerçekleştirir.
- Artırma, azaltma, çarpma, bölme ve mod alma işlemlerini gösterir.

## 🛠️ Nasıl Çalıştırılır?
### Gereksinimler
- .NET SDK kurulu olmalıdır ([Buradan İndirin](https://dotnet.microsoft.com/download))

### Adımlar
1. Bu depoyu klonlayın veya kodu yeni bir C# console projesine ekleyin.
2. Terminali açarak proje dizinine gidin.
3. Aşağıdaki komutu çalıştırarak programı çalıştırın:
   ```sh
   dotnet run
   ```

## 📜 Kod Açıklaması

```csharp
using System.Net.WebSockets;

Console.Write("Adınız nedir?:");
String? name = Console.ReadLine();

Console.Write("Yaşınız kaç?:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Merhaba {name}! {age} yaşındasınız.");

// Aritmetik Operatörler

int friends = 5;

friends++;
Console.WriteLine(friends); // Artırma işlemi

friends--;
Console.WriteLine(friends); // Azaltma işlemi

friends *= 5;
Console.WriteLine(friends); // 5 ile çarpma

friends /= 2;
Console.WriteLine(friends); // 2'ye bölme

int remainder = friends % 5;
Console.WriteLine(remainder); // Mod alma işlemi

Console.ReadKey();
```

### 🎯 Açıklamalar
- **Kullanıcı Girişi**: Program, kullanıcıdan ad ve yaş bilgisini alır ve ekrana yazdırır.
- **Aritmetik İşlemler**:
  - `friends++`: Değişkenin değerini 1 artırır.
  - `friends--`: Değişkenin değerini 1 azaltır.
  - `friends *= 5`: `friends` değişkenini 5 ile çarpar.
  - `friends /= 2`: `friends` değişkenini 2'ye böler.
  - `friends % 5`: `friends` değişkeninin 5'e bölümünden kalanı hesaplar.

## 🚀 Gelecekteki Geliştirmeler
- Kullanıcı giriş hataları için istisna yönetimi ekleme.
- Daha fazla aritmetik işlem örneği ekleme.
- Kullanıcıya farklı matematiksel işlemler yapma seçeneği sunma.

---
📝 **Yazar**: Erenalp YILMAZ  
📌 **Lisans**: MIT  
💡 **Katkıda Bulunma**: Pull request göndermekten çekinmeyin!


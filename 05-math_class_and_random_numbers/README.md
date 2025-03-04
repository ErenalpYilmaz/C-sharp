# 🚀 C# Temelleri: Constants, Type Casting ve Math Kütüphanesi

Bu repo, **C# dilindeki sabitler (constants), tür dönüştürme (type casting) ve Math kütüphanesi** konularını içeren temel bir projedir. C# öğrenme sürecimde edindiğim bilgileri adım adım paylaşarak herkesin bu konuları daha iyi anlamasına yardımcı olmayı amaçlıyorum. 😊

## 📌 İçerik

### 🔹 Constants (Sabitler)
**Constants**, derleme zamanında bilinen ve programın yaşam süresi boyunca değiştirilemeyen değerlerdir. Örneğin, aşağıdaki gibi bir **pi** sabiti tanımlayabiliriz:

```csharp
const double pi = 3.14159;
Console.WriteLine(pi);
```

### 🔹 Type Casting (Tür Dönüştürme)
Farklı veri türleri farklı işlemler yapabilir. C#'ta bir veri türünü başka bir veri türüne çevirmek için **type casting** kullanılır.

📌 **Örnekler:**
- **int → double** dönüşümü:
    ```csharp
    int c = 123;
    double d = Convert.ToDouble(c) + 0.1;
    Console.WriteLine(d);
    ```
- **double → int** dönüşümü:
    ```csharp
    double a = 3.14;
    int b = Convert.ToInt32(a);
    Console.WriteLine(b.GetType());
    ```
- **int → string** dönüşümü:
    ```csharp
    int e = 321;
    string number = Convert.ToString(e);
    Console.WriteLine(number.GetType());
    ```
- **string → bool** dönüşümü:
    ```csharp
    string i = "true";
    bool j = Convert.ToBoolean(i);
    Console.WriteLine(j.GetType());
    ```

### 🔹 Math Kütüphanesi
C#'ın **Math** kütüphanesi, matematiksel işlemleri kolaylaştıran birçok hazır metot içerir. İşte bazı önemli fonksiyonlar:

📌 **Örnekler:**
- **Üs Alma:**
    ```csharp
    double x = 3.14;
    double a = Math.Pow(x, 2); // x^2
    Console.WriteLine($"Your power : {a}");
    ```
- **Karekök Alma:**
    ```csharp
    double b = Math.Sqrt(9);
    Console.WriteLine($"Your number : 9 and new number = {b}");
    ```
- **Mutlak Değer Alma:**
    ```csharp
    double c = Math.Abs(x);
    Console.WriteLine(c);
    ```
- **Yuvarlama İşlemleri:**
    ```csharp
    double d = Math.Round(x); // En yakın tam sayıya yuvarlama
    double e = Math.Ceiling(x); // Yukarı yuvarlama
    double f = Math.Floor(x); // Aşağı yuvarlama
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);
    ```
- **Maksimum ve Minimum Değer Bulma:**
    ```csharp
    double y = 5;
    double g = Math.Max(x, y);
    double h = Math.Min(x, y);
    Console.WriteLine(g);
    Console.WriteLine(h);
    ```

### 🔹 Rastgele Sayılar Üretme
C#'ta **Random** sınıfı kullanılarak rastgele sayılar üretilebilir.

📌 **Örnekler:**
- **Belirli aralıkta rastgele tamsayı üretme:**
    ```csharp
    Random random = new Random();
    int num = random.Next(1, 21); // 1 ile 20 arasında rastgele sayı
    Console.WriteLine($"Random number : {num}");
    ```
- **0 ile 1 arasında rastgele ondalıklı sayı üretme:**
    ```csharp
    double doubleNum = random.NextDouble();
    Console.WriteLine($"Random number : {doubleNum}");
    ```

## 🎯 Çalıştırma
Bu kodları çalıştırmak için **.NET SDK** yüklü olmalıdır. Ardından terminal veya komut istemcisinde şu komutları çalıştırabilirsiniz:
```sh
# C# dosyanızı çalıştırın
csc Program.cs  # Derleme
./Program       # Çalıştırma
```

## 📂 Kaynaklar
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Microsoft Learn C#](https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/)

## 🚀 Katkıda Bulunun
Eğer kodları daha da geliştirmek veya yeni örnekler eklemek isterseniz, pull request gönderebilirsiniz. 😊

---
💡 **Not:** Bu proje, C# öğrenme sürecimde oluşturduğum küçük adımlardan biridir. Daha fazla içerik için takipte kalın! 🚀
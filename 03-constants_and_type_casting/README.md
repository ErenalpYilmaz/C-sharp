# 🚀 C# Temelleri: Constants ve Type Casting

Bu repo, **C# dilindeki sabitler (constants) ve tür dönüştürme (type casting)** konularını içeren temel bir projedir. C# öğrenme sürecimde edindiğim bilgileri adım adım paylaşarak herkesin bu konuları daha iyi anlamasına yardımcı olmayı amaçlıyorum. 😊

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


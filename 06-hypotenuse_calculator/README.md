# 📐 C# ile Dik Üçgen Hipotenüs Hesaplama

Bu proje, kullanıcıdan alınan iki dik kenar uzunluğuna göre **dik üçgenin hipotenüsünü hesaplayan** basit bir C# uygulamasıdır. 📏

## 📌 İçerik
Bu program, **Pisagor Teoremi** kullanarak hipotenüsü hesaplar:

\[ c = \sqrt{a^2 + b^2} \]

📌 **Kod:**
```csharp
Console.Write("1st side of the triangle: ");
double edge1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2nd side of the triangle: ");
double edge2 = Convert.ToDouble(Console.ReadLine());

double hypotenuse = Math.Sqrt((edge1 * edge1) + (edge2 * edge2));

System.Console.WriteLine($"The hypotenuse is: {hypotenuse}");
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
Kodları geliştirmek veya yeni özellikler eklemek isterseniz, pull request gönderebilirsiniz. 😊

---
💡 **Not:** Bu proje, C# öğrenme sürecimde oluşturduğum küçük adımlardan biridir. Daha fazla içerik için takipte kalın! 🚀
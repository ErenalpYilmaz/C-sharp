# 🔢 C# Switch ve Mantıksal Operatörler

Bu proje, **C# programlama dilinde switch-case yapısı ve mantıksal operatörlerin** kullanımını içermektedir. Kullanıcıdan alınan verileri değerlendirerek uygun mesajları ekrana yazdıran bir uygulamadır. 🎯

## 📌 İçerik

### 🔹 Switch-Case Kullanımı
Switch-case, belirli bir değişkenin **birden fazla olası değere göre kontrol edilmesini** sağlar. Bu kod bloğu, kullanıcının girdiği gün ismine göre uygun mesajı yazdırmaktadır:

```csharp
System.Console.WriteLine("What day is it today?");
String? day = Console.ReadLine();

switch (day)
{
  case "Monday":
  case "Tuesday":
  case "Wednesday":
  case "Thursday":
  case "Friday":
  case "Saturday":
  case "Sunday":
    System.Console.WriteLine($"It's {day}!");
    break;
  default:
    System.Console.WriteLine(day+" is not a day!");
    break;
}
```
📌 **Not:** Burada `default` bloğu, geçersiz bir gün girildiğinde hata mesajı vermek için kullanılmıştır.

---

### 🔹 Mantıksal Operatörler (&& ve ||)
Mantıksal operatörler, **koşullu ifadeleri birleştirmek** için kullanılır:

```csharp
System.Console.WriteLine("What's the temperature outside: (C)");
double temp = Convert.ToDouble(Console.ReadLine());

if(temp >= 10 && temp <= 25){
  System.Console.WriteLine("It's warm outside!");
}
else if(temp <= -50 || temp >= 50){
  System.Console.WriteLine("DON'T GO OUTSIDE!!!");
}
```

📌 **&& (AND) Operatörü:** İki koşulun da **doğru olması** gerektiğini belirtir.
- Örneğin, sıcaklık 10 ile 25 derece arasındaysa "It's warm outside!" mesajı gösterilir.

📌 **|| (OR) Operatörü:** En az bir koşul doğruysa ifadeyi çalıştırır.
- Sıcaklık -50'nin altında veya 50'nin üzerinde olduğunda "DON'T GO OUTSIDE!!!" mesajı gösterilir.

---

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
Bu projeyi geliştirerek katkıda bulunabilirsiniz. Pull request göndermekten çekinmeyin! 😊

---
💡 **Not:** Bu proje, C# öğrenme sürecimde oluşturduğum küçük adımlardan biridir. Daha fazla içerik için takipte kalın! 🚀


# 🔁 C# ile Döngüler (Loops)

Bu proje, **C# dilinde kullanılan döngüleri** içeren temel örnekleri kapsar. **While ve For döngülerinin** nasıl çalıştığını anlamak için kullanışlı bir kaynaktır. 🔄

## 📌 İçerik

### 🔹 While Döngüsü
Bir koşul **doğru (true)** olduğu sürece kod bloğunu tekrar eden bir döngüdür. Örneğin, kullanıcıdan geçerli bir isim alana kadar tekrar eden bir giriş mekanizması oluşturabiliriz:

```csharp
String? name = "";

while(name == ""){
  System.Console.WriteLine("Enter your name:");
  name = Console.ReadLine();
}
System.Console.WriteLine("Hello "+name);
```
Bu kod parçasında, **kullanıcı geçerli bir giriş yapana kadar** döngü devam eder.

---

### 🔹 For Döngüsü
For döngüsü, belirli bir sayıda işlemi tekrar etmek için kullanılır. Örneğin, 0'dan 9'a kadar sayıları ekrana yazdırabiliriz:

```csharp
for(int i = 0; i < 10; i++){
  System.Console.WriteLine(i);
}
```
Bu döngü şu şekilde çalışır:
1. **Başlangıç değeri:** `int i = 0`
2. **Koşul:** `i < 10` (i, 10’dan küçük olduğu sürece döngü devam eder)
3. **Artış:** `i++` (Her tekrar sonunda `i` değeri 1 artırılır)

---

## 🎯 Çalıştırma
Bu kodları çalıştırmak için **.NET SDK** yüklü olmalıdır. Terminal veya komut istemcisinde şu komutları çalıştırabilirsiniz:
```sh
# C# dosyanızı derleyin ve çalıştırın
csc Program.cs  # Derleme
./Program       # Çalıştırma
```

## 📂 Kaynaklar
- [C# While Loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
- [C# For Loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)

## 🚀 Katkıda Bulunun
Kodları geliştirmek veya yeni özellikler eklemek isterseniz, pull request gönderebilirsiniz. 😊

---
💡 **Not:** Bu proje, C# öğrenme sürecimde oluşturduğum küçük adımlardan biridir. Daha fazla içerik için takipte kalın! 🚀
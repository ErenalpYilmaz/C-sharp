# 🔤 C# ile String Manipülasyonu ve Koşullu İfadeler

Bu proje, **C# dilindeki string (metin) manipülasyonu ve koşullu ifadeler** işlemlerini içeren temel bir uygulamadır. **Metinleri değiştirme, karakter ekleme, kaldırma ve kullanıcı girişine dayalı koşullu işlemler** bu projede ele alınmaktadır. 📜

## 📌 İçerik

### 🔹 Büyük/Küçük Harfe Çevirme
Metni **büyük harfe** veya **küçük harfe** dönüştürmek için **ToUpper()** ve **ToLower()** metodları kullanılır:
```csharp
String fullName = "Eren Alp";
fullName = fullName.ToUpper();
System.Console.WriteLine($"Your upper name: {fullName}");

fullName = fullName.ToLower();
System.Console.WriteLine($"Your lower name: {fullName}");
```

### 🔹 Karakter Değiştirme
Bir string içerisindeki belirli karakterleri değiştirmek için **Replace()** metodu kullanılır:
```csharp
String phoneNumber = "123-456-7890";
phoneNumber = phoneNumber.Replace("-", "");
System.Console.WriteLine($"Your phone number: {phoneNumber}");
```

### 🔹 Metnin Başına Karakter Ekleme
**Insert()** metodu kullanılarak string'in belirli bir konumuna metin eklenebilir:
```csharp
String userName = fullName.Insert(0, "@");
System.Console.WriteLine($"Your username: {userName}");
```
```csharp
String userName2 = fullName.Insert(0, "Mr.");
System.Console.WriteLine($"Your username: {userName2}");
```

### 🔹 String Uzunluğunu Bulma
Bir string'in karakter sayısını öğrenmek için **Length** özelliği kullanılır:
```csharp
int name_length = fullName.Length;
System.Console.WriteLine($"Your name's length: {name_length}");
```

### 🔹 Belirli Bir Kısmı Alma (Substring)
Bir metnin belirli bir kısmını almak için **Substring()** metodu kullanılır:
```csharp
String firstName = fullName.Substring(0,4);
String lastName = fullName.Substring(5,3);
System.Console.WriteLine($"Your first name: {firstName} & last name: {lastName}");
```

### 🔹 Koşullu İfadeler (if-else)
Kullanıcıdan yaş bilgisi alarak uygun mesajları görüntüleyen **if-else** yapısı:
```csharp
System.Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 100)
{
   System.Console.WriteLine("You are too old to sign up!");
}
else if (age >= 18){
  System.Console.WriteLine("You are now signed up!");
}
else if (age < 0){
  System.Console.WriteLine("You haven't been born yet!");
}
else{
  System.Console.WriteLine("You must be 18+ to sign up!");
}
```

### 🔹 Kullanıcı Adı Girişi
Kullanıcıdan isim alarak boş olup olmadığını kontrol eden yapı:
```csharp
Console.WriteLine("Please enter your name: ");
String? name = Console.ReadLine();

if(name != ""){
  System.Console.WriteLine("Hello "+name);
}
else{
  System.Console.WriteLine("You didn't enter your name!");
}
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
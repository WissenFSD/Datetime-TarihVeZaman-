// See https://aka.ms/new-console-template for more information

//  c# tarih ve zaman ile ilgili konular datetime denen bir değişken ile yönetilir


// Şimdiyi verecektir
DateTime date = DateTime.Now;
Console.WriteLine(date);



// İstediğin tarih zamanı oluşturabilirsin
DateTime tarih = new DateTime(2007, 12, 01);


// 
// mevcut saate eklemeler yada çıkartmalar yapılabilir.
DateTime.Now.AddHours(1000);
DateTime.Now.AddMinutes(2000);
DateTime.Now.AddSeconds(1000);



// Leap year kontrolü yapılabilr(Artık yıl bulma)

bool isleap  = DateTime.IsLeapYear(DateTime.Now.Year);
Console.WriteLine(isleap);





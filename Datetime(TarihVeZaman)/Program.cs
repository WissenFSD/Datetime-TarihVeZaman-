// See https://aka.ms/new-console-template for more information

//  c# tarih ve zaman ile ilgili konular datetime denen bir değişken ile yönetilir


// Şimdiyi verecektir
DateTime date = DateTime.Now;
Console.WriteLine(date);



// İstediğin tarih zamanı oluşturabilirsin
DateTime tarih = new DateTime(2007, 12, 01);

// Milisaniyeye kadar tanımlama imkanı var
DateTime tarih2 = new DateTime(2017, 12, 14, 5, 18, 55, 100);
Console.WriteLine(tarih2);


// 
// mevcut saate eklemeler yada çıkartmalar yapılabilir.

// bir gün sonrası
DateTime.Now.AddDays(1);
// bie son öncesi
DateTime.Now.AddDays(-1);

// 1000 dakika sonrası
DateTime.Now.AddHours(1000);

// 2000 dakika sonrası
DateTime.Now.AddMinutes(2000);

// 1000 saniye sonrası
DateTime.Now.AddSeconds(1000);

// Ekrana yazdırma metotları

Console.WriteLine("Short Time String {0}",DateTime.Now.ToShortTimeString());
Console.WriteLine("Long Time String {0}", DateTime.Now.ToLongTimeString());
Console.WriteLine("Long Date String {0}", DateTime.Now.ToLongDateString());

// Leap year kontrolü yapılabilr(Artık yıl bulma)
bool isleap  = DateTime.IsLeapYear(DateTime.Now.Year);
Console.WriteLine(isleap);

// Bu yılı alma
Console.WriteLine(DateTime.Now.Year);

// Yılın günü
Console.WriteLine("Day Of Year {0}",DateTime.Now.DayOfYear);

// Haftanın günü
Console.WriteLine("Day of week {0}",DateTime.Now.DayOfWeek);



DateTime baglangicTarih = new DateTime(1994, 05, 14);
// İki tarih arasındaki farkı alma
TimeSpan fark = DateTime.Now - baglangicTarih;
Console.WriteLine("İki tarih arasındaki fark gün olarak {0}",fark.TotalHours);


// çıktıyı formatlamak 

// Formatlamak istediğimiz şekilde formatı değiştirebiliriz
//string format = "MMM ddd d HH:MM yyyy";
string format = "yy/dd/MM";
DateTime tarih5 = DateTime.Now;
Console.WriteLine(tarih5.ToString(format));







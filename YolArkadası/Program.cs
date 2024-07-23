// See https://aka.ms/new-console-template for more information
Console.WriteLine("Yol Arkadaşım Uygulamasına Hoş Geldiniz!");
string islem = "evet";
// her işlem sonunda devam ederse tekrar hesaplama yapması için yazıldı.
while (islem == "evet")
{
    string message = "3 adet lokasyonumuz bulunmaktadır. \n 1- Bodrum (Paket Başlangıç Fiyatı 4000 TL)" +
     "\n 2-Marmaris(Paket Başlangıç Fiyatı 3000 TL) \n 3- Çeşme (Paket Başlangıç Fiyatı 5000 TL) \n Hangi lokasyonu tercih ederseniz?";

    Console.WriteLine(message);
    string lokasyon = Console.ReadLine();
    int kisi;
    // yanlış girdiği müddetçe lokasyon tekrar istenecektir.
    while (lokasyon.ToLower() != "bodrum" && lokasyon.ToLower() != "marmaris" && lokasyon.ToLower() != "çeşme")
    {
        Console.WriteLine("Hatalı giriş yaptınız! \n " + message);
        lokasyon = Console.ReadLine();

    }

    Console.WriteLine("Kaç kişi gitmeyi planlıyorsunuz?");
    kisi = int.Parse(Console.ReadLine());
    // yapılacaklar hakkında kısa bilgi
    Console.WriteLine("Seçtiğiniz " + lokasyon.ToUpper() + " lokasyonumuzda tarihi gezilere,ege yöresel lezzetlerine, koy koy gezebileceğiniz tekne turlarına,temiz ve sıcacık ege sahillerinde yüzme keyfine katılabileceksiniz.\n\n");
    // ulaşım aracı seçimi
    int arac = 0;
    Console.WriteLine("Peki hangi ulaşım aracını tercih edersiniz? \n 1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n 2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\r\n 1 ya da 2 yazmanız yeterlidir.\n\n");
    arac = int.Parse(Console.ReadLine());
    while (arac != 1 && arac != 2)
    {
        Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz! \n 1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n 2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\r\n 1 ya da 2 yazmanız yeterlidir. ");
        arac = int.Parse(Console.ReadLine());

    }
    // işlemleri yapıyoruz.
    int toplam = kisi;
    switch (lokasyon)
    {
        case "bodrum":
            toplam *= 4000;
            break;
        case "marmaris":
            toplam *= 3000;
            break;
        case "çeşme":
            toplam *= 5000;
            break;

    }
    if (arac == 1)
        toplam += (kisi * 1500);
    else
        toplam += (kisi * 4000);

    Console.WriteLine("\n\nToplam ödeyeceğiniz tutar "+ toplam +" TL'dir \n Başka işlem yapmak ister misiniz? (evet/hayır) \n\n");
    islem = Console.ReadLine().ToLower();
    Console.WriteLine("----------------------------");

}











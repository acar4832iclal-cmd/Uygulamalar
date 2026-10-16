using System.ComponentModel.Design;

static bool OduncUygunMu(bool odunctemi, int gun)
{
    bool sonuc = !odunctemi && gun >= 1 && gun <= 7;
    return sonuc;
}
Console.Write("Ödünç alacağınız gün sayısını giriniz:");
string? giris = Console.ReadLine();
if (int.TryParse(giris, out int gunsayisi))
{
    if (gunsayisi >= 1 && gunsayisi <= 7)
    {
        bool ekipmanoduncteMi = true;
        bool sonuc = OduncUygunMu(false, gunsayisi);
        if (sonuc)
        {
            Console.WriteLine("Girişiniz onaylandı. " + gunsayisi + " günlük ödünç talebiniz kabul edilmiştir.");
        }
        else
        {
            Console.WriteLine("Talebiniz reddedilmiştir. Elipman şu an ödünçtedir.");
        }
    }
    else
    {
        Console.WriteLine("1 ile 7 arasında bir sayı girmelisiniz.");
    }

}
else
{
    Console.WriteLine("Lütfen harf kullanmadan 1 ile 7 arası bir sayı giriniz");
}

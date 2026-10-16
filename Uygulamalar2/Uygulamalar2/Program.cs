static bool NumaraVarMi(List<string> liste, string aranan)
{
    foreach (string numara in liste)
    {
        if (numara == aranan)
            return true;
    }
    return false;
}

List<string> numaralar = new List<string> { "05559486055", "05457804010", "05539252036" };
bool ilkNumara = NumaraVarMi(numaralar, "05559486055");
Console.WriteLine("Bu numara listede bulunuyor mu? " + ilkNumara);
bool sonNumara = NumaraVarMi(numaralar, "05539252036");
Console.WriteLine("Bu numara listede bulunuyor mu? " + sonNumara);
bool olmayanNumara = NumaraVarMi(numaralar, "05009998877");
Console.WriteLine("Bu numara listede bulunuyor mu? " + olmayanNumara);
List<string> bosList = new List<string>();






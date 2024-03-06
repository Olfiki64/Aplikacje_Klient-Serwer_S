using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataFiles
{
    public class Ocena
{
    public DateTime DataWydania { get; set; }
    public WartoscOceny WartoscOceny { get; set; }
    public Przedmiot Przedmiot { get; set; }
    public int IdPrzedmiotu { get; set; }
    public int IdUcznia { get; set; }
    public Uczen Uczen { get; set; }

    public Ocena()
    {
    }

    public Ocena(DateTime dataWydania, WartośćOceny wartośćOceny, 
        Przedmiot przedmiot, int idPrzedmiotu, int idUcznia, Uczeń uczeń)
    {
        DataWydania = dataWydania;
        WartoscOceny = wartośćOceny;
        Przedmiot = przedmiot;
        IdPrzedmiotu = idPrzedmiotu;
        IdUcznia = idUcznia;
        Uczen = uczeń;
    }
}

public enum WartośćOceny
{
    Niedostateczny,
    Dopuszczający,
    Dostateczny,
    Dobry,
    BardzoDobry,
    Celujący
}

public class Przedmiot
{
    public string Nazwa { get; set; }
    public int IdPrzedmiotu { get; set; }

    public Przedmiot()
    {
    }

    public Przedmiot(string nazwa, int idPrzedmiotu)
    {
        Nazwa = nazwa;
        IdPrzedmiotu = idPrzedmiotu;
    }
}

public class Uczeń
{
    public string Imię { get; set; }
    public string Nazwisko { get; set; }
    public int IdUcznia { get; set; }

    public Uczeń()
    {
    }

    public Uczeń(string imię, string nazwisko, int idUcznia)
    {
        Imię = imię;
        Nazwisko = nazwisko;
        IdUcznia = idUcznia;
    }
}

}
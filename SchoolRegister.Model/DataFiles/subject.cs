using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataFiles
{
    public class Przedmiot
{
    public int Id { get; set; }
    public string Nazwa { get; set; }
    public string Opis { get; set; }

    public IList<GrupaPrzedmiotow> GrupyPrzedmiotow { get; set; }
    public Nauczyciel Nauczyciel { get; set; }
    public int? NauczycielId { get; set; }

    public IList<Ocena> Oceny { get; set; }

    public Przedmiot()
    {
        GrupyPrzedmiotow = new List<GrupaPrzedmiotow>();
        Oceny = new List<Ocena>();
    }
}

public class GrupaPrzedmiotow
{
    public int Id { get; set; }
    public string Nazwa { get; set; }

    public IList<Przedmiot> Przedmioty { get; set; }

    public GrupaPrzedmiotow()
    {
        Przedmioty = new List<Przedmiot>();
    }
}

public class Nauczyciel
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public IList<Przedmiot> Przedmioty { get; set; }

    public Nauczyciel()
    {
        Przedmioty = new List<Przedmiot>();
    }
}

public class Ocena
{
    public int Id { get; set; }
    public int Wartosc { get; set; }
    public string Uwagi { get; set; }

    public Przedmiot Przedmiot { get; set; }
    public int PrzedmiotId { get; set; }

    public Uczen Uczen { get; set; }
    public int UczenId { get; set; }
}

public class Uczen
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public IList<Ocena> Oceny { get; set; }

    public Uczen()
    {
        Oceny = new List<Ocena>();
    }
}

}
using System.Runtime.CompilerServices;

namespace Edilizia.Models
{
    public static class Db
    {
        private static int _maxId = 3;

        private static List<Dipendente> _dipendenti {  get; set; } = [
            
            new Dipendente() { IDdipendente = 1, Nome = "Francesco", Cognome="Missorini", Indirizzo= "via non lo so", CodiceFiscale = "dkslfdkjlfwsdk", Coniugato = true , Figli = 10, Mansione="Carabiniere"},
            new Dipendente() { IDdipendente = 2, Nome = "Mario", Cognome = "Rossi", Indirizzo = "via lo so", CodiceFiscale = "dkslfdhjkfwsdk", Coniugato = false, Figli = 2, Mansione = "Commesso" },
            new Dipendente() { IDdipendente = 3, Nome = "Alberto", Cognome = "Neri", Indirizzo = "via so ", CodiceFiscale = "dkslfujjjlfwsdk", Coniugato = true, Figli = 1, Mansione = "Carabiniere" }

            ];
        public static List<Dipendente> getAll()
        {
            return _dipendenti;
        }

        public static Dipendente? getById(int? id)
        {
            if (id == null) return null;

            for(int i=0; i < _dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (_dipendenti[i].IDdipendente == id)
                {
                    return dipendente;
                }
            }

            return null;

        }

        public static Dipendente AggiungiDipendente(string nome, string cognome, string indirizzo, string codicefiscale, bool coniugato, int figli, string mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { IDdipendente = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codicefiscale, Coniugato = coniugato, Figli = figli, Mansione = mansione };
            _dipendenti.Add(dipendente);
            return dipendente;

        }




    }
}

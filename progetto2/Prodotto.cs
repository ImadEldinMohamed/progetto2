using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto2
{
    internal class Prodotto
    {
        public string Nome { get; set; }

        public int Prezzo { get; set; }

        public int Quantità { get; set; }

        public string CalcolaTotale()
        {
            return Nome + (Prezzo * Quantità);
        }


        public Prodotto() { }
        public Prodotto(string nome,int prezzo,int quantità) { 
                this.Nome = nome;
                 this.Prezzo = prezzo;
            this.Quantità = quantità;
        
        
        }


    }
}

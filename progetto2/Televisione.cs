using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace progetto2
{
    internal class Televisione
    {

        public bool AccesoOspento { get; set; }
        public int Volume { get; set; }

        public int Canale{ get; set; }

        public bool Silenzio { get; set; }


        public void PulsanteAccensione()
        {
            if (AccesoOspento)
            {
                this.AccesoOspento = true;
            }
            else
            {
                this.AccesoOspento = false;
            }
            
        }

        public void CanaleSuccessivo()
        {
            if (AccesoOspento)
            {
                Canale += 1;
            }
        }

        public void CanalePrecedente()
        {
            if (AccesoOspento)
            {
                Canale -= 1;
            }
        }

        public void AbbassaVolume()
        {
            if (AccesoOspento && Volume>0)
            {
                Volume-=1;
            }
        }


        public void AlzaVolume()
        {
            if (AccesoOspento && Volume <=10)
            {
                Volume+=1;
            }
        }



        public void ImpostaCanale(int c)
        {
            if (AccesoOspento && c >= 0 && c <= 99)
            {
                Canale = c;
            }
        }


        public void pulsanteSilenzioso()
        {
            if (Silenzio)
            {
                this.Silenzio = true;
            }
            else
            {
                this.Silenzio= false;
            }
        }

        public void PrintStatotv()
        {
            if (AccesoOspento) {
                Console.WriteLine($"volume { Volume} " );
            
            }
        }


        public Televisione() { }

        public Televisione(bool accesoOspento,int volume,int canale,bool silenzio) {
            this.AccesoOspento = accesoOspento;
            this.Volume = volume;
             this.Canale = canale;
            this.Silenzio = silenzio;
        
        
        }
    }
}

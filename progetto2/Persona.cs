namespace progetto2
{
    internal class Persona
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public int Età { get; set; }


        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }
        public int GetEta()
        {
            return Età;
        }

        public string GetDettagli()
        {
            return Nome + " " + Cognome + "" + Età ;
        }


        public Persona() { }
        public Persona(string nome ,string cognome,int età) { 
          this.Nome = nome; 
            this.Cognome = cognome;
            this.Età = età;
        
        
        }
    }
}

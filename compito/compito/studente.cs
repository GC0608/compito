using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito
{
    class studente : Persona
    {
        public string sezione {get ; set ;}
        public Persona (string nome , string cognome , int anni) : base (nome , cognome , anni)
    {
        this.sezione = sezione;
    }
    }
}

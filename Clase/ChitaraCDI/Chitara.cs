using System;
using System.Collections.Generic;
using System.Text;

namespace ChitaraCDI
{
    class Chitara
    {
        //atribute
        public string nume;
        public float pret;
        public bool esteElectrica;
        private int nrCorzi;
        protected bool esteBass;

        //constructor deafult(fara parametrii)
        public Chitara()
        {
            this.nume = "Fender";
            this.pret = (float)800.58;
            this.esteElectrica = true;
            this.nrCorzi = 8;
            this.esteBass = false;
        }

        // contructor cu parametrii
        public Chitara(string numeBoss, float catCosta, bool eElectricaDaia)
        {
            this.nume = numeBoss;
            this.pret = catCosta;
            this.esteElectrica = eElectricaDaia;
        }

        public int GetNrCorzi()
        {
            return this.nrCorzi;
        }

        public void SetNrCorzi(int NumarulCorzilor)
        {
            this.nrCorzi = NumarulCorzilor;
        }

        public bool GetEsteBass()
        {
            return this.esteBass;
        }

        public void SetEbass(bool Ebass)
        {
            this.esteBass = Ebass;
        }

    }
}
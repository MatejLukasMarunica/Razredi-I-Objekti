using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrediIObjekti
{
    internal class Neboder
    {
        private float visina = 200;
        private int katovi = 100;
        int kat = 1;
        int visi = 10;
       

        public Neboder()
        {
        }

       
        public void setvisina(float visina)
        {
            this.visina = visina;
        }
        public void setkatovi(int katovi)
        {
            this.katovi = katovi;
        }


        public float getvisina()
        {
            return this.visina + visi;
        }

        public int getkatovi()
        {
            return this.katovi + kat;
        }


        public override string ToString()
        {
            string ispis = "Visina Nebodera: " + this.getvisina() + " m" + Environment.NewLine + " Katovi Nebodera iznose: " + this.getkatovi() + " m" Environment.NewLine + " Prosjek je: " + this.getvisina()/this.getkatovi() + " m";
            return ispis;
        }

        public Neboder(int visina, int katovi)
        {
            this.visina = visina;
            this.katovi = katovi;
        }


        

    }
}

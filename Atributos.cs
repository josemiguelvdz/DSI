using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3JoseMiguelVillacanas
{
    class Atributos
    {
        int diamantes=0;
        double volumen = 100;
        int nivelActual;
        bool [] niveles = { true, false, false, false };  

        public void setDiamantes(int d)
        {
            diamantes += d;
        }
        public int getDiamantes()
        {
            return diamantes;
        }

        public void setNivel(int index)
        {
            niveles[index] = true;
        }
        public bool getNivel(int index)
        {
            return niveles[index];
        }

        public void setNivelActual(int i)
        {
            nivelActual = i;
        }
        public int getNivelActual()
        {
            return nivelActual;
        }

        public void setVolume(double v)
        {
            volumen = v;
        }

        public double getVolume()
        {
            return volumen/100;
        }

    }
}

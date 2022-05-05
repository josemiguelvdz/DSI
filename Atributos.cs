﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3JoseMiguelVillacanas
{
    class Atributos
    {
        public int diamantes=0;
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

    }
}
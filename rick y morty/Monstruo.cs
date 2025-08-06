using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rick_y_morty
{
    public class Monstruo
    {
        // Instancia de Random para que cada monstruo calcule su propio daño.
        private Random random = new Random();

        // Propiedades del Monstruo
        public string Nombre { get; set; }

        // Vida máxima del monstruo. Se usa para la barra de vida.
        public int Vida { get; set; }

        public int VidaActual { get; set; }

        // Rango de daño del monstruo
        public int AtaqueMin { get; set; }
        public int AtaqueMax { get; set; }

        public Monstruo()
        {
        }

        public int Atacar()
        {
            return random.Next(AtaqueMin, AtaqueMax + 1);
        }

        public void RecibirDaño(int daño)
        {
            // Reduce la vida y asegura que no baje de 0.
            VidaActual = Math.Max(0, VidaActual - daño);
        }

        public bool EstaVivo()
        {
            return VidaActual > 0;
        }
    }
}
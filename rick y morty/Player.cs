using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rick_y_morty
{
    // Clase para el jugador principal (Caballero)
    public class Player
    {
        private Random random = new Random();

        public string Nombre { get; set; }
        public int VidaMaxima { get; private set; }
        public int VidaActual { get; set; }
        public bool TieneDañoExtra { get; set; } // Para el efecto del ataque a dos manos

        public Player(string nombre)
        {
            Nombre = nombre;
            VidaMaxima = 70;
            VidaActual = 70;
            TieneDañoExtra = false;
        }

        // Método para atacar (5-30 puntos de daño)
        public int Atacar()
        {
            return random.Next(5, 31); // 5 a 30 inclusive
        }

        // Método para ataque a dos manos (7-42 puntos de daño)
        public int AtaqueDosManos()
        {
            TieneDañoExtra = true; // Recibirá 50% más daño el siguiente turno
            return random.Next(7, 43); // 7 a 42 inclusive
        }

        // Método para curar (4-24 puntos de vida)
        public int Curar()
        {
            int curacion = random.Next(4, 25); // 4 a 24 inclusive
            VidaActual = Math.Min(VidaActual + curacion, VidaMaxima);
            return curacion;
        }

        // Método para recibir daño
        public void RecibirDaño(int daño, bool esDefendiendo = false)
        {
            if (esDefendiendo)
            {
                daño = (int)(daño * 0.5); // 50% del daño si está defendiendo
            }
            else if (TieneDañoExtra)
            {
                daño = (int)(daño * 1.5); // 50% más daño por el ataque a dos manos
                TieneDañoExtra = false; // Se resetea después de recibir el daño extra
            }

            VidaActual = Math.Max(0, VidaActual - daño);
        }

        // Verificar si el jugador está vivo
        public bool EstaVivo()
        {
            return VidaActual > 0;
        }

        // Obtener porcentaje de vida
        public double PorcentajeVida()
        {
            return (double)VidaActual / VidaMaxima * 100;
        }
    }
}

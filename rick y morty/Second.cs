using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rick_y_morty
{
    public class Second
    {
        private Random random = new Random();

        public string Nombre { get; set; }
        public int VidaMaxima { get; private set; }
        public int VidaActual { get; set; }
        public bool EstaNoqueado { get; private set; }

        public Second(string nombre)
        {
            Nombre = nombre;
            VidaMaxima = 30;
            VidaActual = 30;
            EstaNoqueado = false;
        }

        // Método para atacar automáticamente (3-18 puntos de daño)
        public int AtacarAutomatico()
        {
            if (EstaNoqueado)
                return 0; // No puede atacar si está noqueado

            return random.Next(3, 19); // 3 a 18 inclusive
        }

        // Método para recibir curación
        public int RecibirCuracion(int curacion)
        {
            if (EstaNoqueado)
                return 0; // No se puede curar si está noqueado

            int vidaAnterior = VidaActual;
            VidaActual = Math.Min(VidaActual + curacion, VidaMaxima);
            return VidaActual - vidaAnterior; // Retorna la cantidad realmente curada
        }

        // Método para recibir daño
        public void RecibirDaño(int daño)
        {
            VidaActual = Math.Max(0, VidaActual - daño);

            // Si la vida llega a 0 o menos, queda noqueado
            if (VidaActual <= 0)
            {
                EstaNoqueado = true;
            }
        }

        // Método para revivir al paje (por si implementas algo así más tarde)
        public void Revivir(int vidaInicial = 1)
        {
            if (EstaNoqueado)
            {
                VidaActual = Math.Min(vidaInicial, VidaMaxima);
                EstaNoqueado = false;
            }
        }

        // Verificar si puede actuar
        public bool PuedeActuar()
        {
            return !EstaNoqueado && VidaActual > 0;
        }

        // Obtener porcentaje de vida
        public double PorcentajeVida()
        {
            return (double)VidaActual / VidaMaxima * 100;
        }
    }
}

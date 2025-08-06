using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rick_y_morty
{
    public partial class Form1 : Form
    {
        private List<Monstruo> listaMonstruos = new List<Monstruo>();
        private List<Monstruo> atacantes = new List<Monstruo>(); // Nueva lista para los atacantes
        private Random random = new Random(); // Para generar números aleatorios

        // Agregar estas variables a tu clase Form1
        private Player jugadorPrincipal;
        private Second paje;
        private bool defendiendoEsteTurno = false; // Para controlar si el jugador está defendiendo

        // Modificar tu código existente en el constructor Form1()
        public Form1()
        {
            InitializeComponent();
            pic_Fondo.Image = Image.FromFile(@"images/Fondo.jpg");
            pic_Fondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Fondo.Dock = DockStyle.Fill;

            // Configurar el título con PictureBox
            pic_titulo.Image = Image.FromFile(@"images/Titulo.png");
            pic_titulo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_titulo.BackColor = Color.Transparent;
            pic_titulo.Parent = pic_Fondo;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Rick y Morty";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            string personaje = PreguntarPersonaje();

            if (personaje == "Rick")
            {
                // Crear instancias de jugador y paje
                jugadorPrincipal = new Player("Rick");
                paje = new Second("Morty");

                // Configurar imágenes
                pic_main.Image = Image.FromFile(@"images/Ryck.png");
                pic_main.SizeMode = PictureBoxSizeMode.Zoom;
                pic_main.BackColor = Color.Transparent;
                pic_main.Parent = pic_Fondo;
                pic_main.Visible = true;

                pic_second.Image = Image.FromFile(@"images/Morty.png");
                pic_second.SizeMode = PictureBoxSizeMode.Zoom;
                pic_second.BackColor = Color.Transparent;
                pic_second.Parent = pic_Fondo;
                pic_second.Visible = true;
            }
            else if (personaje == "Morty")
            {
                // Crear instancias de jugador y paje
                jugadorPrincipal = new Player("Morty");
                paje = new Second("Rick");

                // Configurar imágenes
                pic_main.Image = Image.FromFile(@"images/Morty.png");
                pic_main.SizeMode = PictureBoxSizeMode.Zoom;
                pic_main.BackColor = Color.Transparent;
                pic_main.Parent = pic_Fondo;
                pic_main.Visible = true;

                pic_second.Image = Image.FromFile(@"images/Ryck.png");
                pic_second.SizeMode = PictureBoxSizeMode.Zoom;
                pic_second.BackColor = Color.Transparent;
                pic_second.Parent = pic_Fondo;
                pic_second.Visible = true;
            }

            // Configurar los labels
            ConfigurarLabels();
            ActualizarInterfaz();
            ConfigurarBotones();

            CargarMonstruos();
            CargarUno();
            ActualizarMonstruosEnPantalla();
        }

        private void ConfigurarBotones()
        {
            // Estilo común
            Font fuenteBoton = new Font("Comic Sans MS", 11, FontStyle.Bold);
            Color colorTexto = Color.White;

            // Botón Golpe Portal (Atacar)
            btn_golpe.Font = fuenteBoton;
            btn_golpe.ForeColor = colorTexto;
            btn_golpe.BackColor = Color.DarkSlateBlue;
            btn_golpe.FlatStyle = FlatStyle.Flat;
            btn_golpe.FlatAppearance.BorderSize = 0;
            btn_golpe.Parent = pic_Fondo;
            btn_golpe.Text = "Golpe";

            // Botón Suero (Curar)
            btn_suero.Font = fuenteBoton;
            btn_suero.ForeColor = colorTexto;
            btn_suero.BackColor = Color.DarkGreen;
            btn_suero.FlatStyle = FlatStyle.Flat;
            btn_suero.FlatAppearance.BorderSize = 0;
            btn_suero.Parent = pic_Fondo;
            btn_suero.Text = "Suero";

            // Botón Berserker (Ataque a dos manos)
            btn_berserker.Font = fuenteBoton;
            btn_berserker.ForeColor = colorTexto;
            btn_berserker.BackColor = Color.DarkRed;
            btn_berserker.FlatStyle = FlatStyle.Flat;
            btn_berserker.FlatAppearance.BorderSize = 0;
            btn_berserker.Parent = pic_Fondo;
            btn_berserker.Text = "Berserker";

            // Botón Burla (Defender)
            btn_burla.Font = fuenteBoton;
            btn_burla.ForeColor = colorTexto;
            btn_burla.BackColor = Color.DarkOrange;
            btn_burla.FlatStyle = FlatStyle.Flat;
            btn_burla.FlatAppearance.BorderSize = 0;
            btn_burla.Parent = pic_Fondo;
            btn_burla.Text = "Burla";
        }

        // Método para configurar la apariencia de los labels
        private void ConfigurarLabels()
        {
            // === Estilo común para nombres ===
            Font fuenteNombre = new Font("Arial", 12, FontStyle.Bold);
            Color colorNombre = Color.White;

            // === Estilo común para HP ===
            Font fuenteHP = new Font("Arial", 10, FontStyle.Bold);
            Color colorHP = Color.LimeGreen;

            // === Jugador principal ===
            player_name.Font = fuenteNombre;
            player_name.ForeColor = colorNombre;
            player_name.BackColor = Color.Transparent;
            player_name.Parent = pic_Fondo;

            player_hp.Font = fuenteHP;
            player_hp.ForeColor = colorHP;
            player_hp.BackColor = Color.Transparent;
            player_hp.Parent = pic_Fondo;

            // === Paje ===
            second_name.Font = fuenteNombre;
            second_name.ForeColor = colorNombre;
            second_name.BackColor = Color.Transparent;
            second_name.Parent = pic_Fondo;

            second_live.Font = fuenteHP;
            second_live.ForeColor = colorHP;
            second_live.BackColor = Color.Transparent;
            second_live.Parent = pic_Fondo;

            // === Monstruo 1 ===
            mst1_name.Font = fuenteNombre;
            mst1_name.ForeColor = colorNombre;
            mst1_name.BackColor = Color.Transparent;
            mst1_name.Parent = pic_Fondo;

            mst1_live.Font = fuenteHP;
            mst1_live.ForeColor = colorHP;
            mst1_live.BackColor = Color.Transparent;
            mst1_live.Parent = pic_Fondo;
        }

        // Método para actualizar la información en pantalla
        private void ActualizarInterfaz()
        {
            if (jugadorPrincipal != null && paje != null)
            {
                // Actualizar información del jugador principal
                player_name.Text = jugadorPrincipal.Nombre;
                player_hp.Text = $"HP: {jugadorPrincipal.VidaActual}/{jugadorPrincipal.VidaMaxima}";

                // Cambiar color según el estado de vida del jugador
                if (jugadorPrincipal.PorcentajeVida() > 50)
                    player_hp.ForeColor = Color.LimeGreen;
                else if (jugadorPrincipal.PorcentajeVida() > 25)
                    player_hp.ForeColor = Color.Yellow;
                else
                    player_hp.ForeColor = Color.Red;

                // Actualizar información del paje
                second_name.Text = paje.Nombre;

                if (paje.EstaNoqueado)
                {
                    second_live.Text = "NOQUEADO";
                    second_live.ForeColor = Color.Red;
                }
                else
                {
                    second_live.Text = $"HP: {paje.VidaActual}/{paje.VidaMaxima}";

                    // Cambiar color según el estado de vida del paje
                    if (paje.PorcentajeVida() > 50)
                        second_live.ForeColor = Color.LimeGreen;
                    else if (paje.PorcentajeVida() > 25)
                        second_live.ForeColor = Color.Yellow;
                    else
                        second_live.ForeColor = Color.Red;
                }
            }

            // Actualizar monstruos
            if (atacantes.Count > 0)
            {
                mst1_name.Text = atacantes[0].Nombre;
                mst1_live.Text = $"HP: {atacantes[0].VidaActual}/{atacantes[0].Vida}";

                // Cambiar color según vida del monstruo
                double porcentajeVidaMonstruo = (double)atacantes[0].VidaActual / atacantes[0].Vida * 100;
                if (porcentajeVidaMonstruo > 50)
                    mst1_live.ForeColor = Color.LimeGreen;
                else if (porcentajeVidaMonstruo > 25)
                    mst1_live.ForeColor = Color.Yellow;
                else
                    mst1_live.ForeColor = Color.Red;
            }
        }

        // Método para cuando el jugador recibe daño (ejemplo de uso)
        public void JugadorRecibeDaño(int daño, bool defendiendo = false)
        {
            if (jugadorPrincipal != null)
            {
                jugadorPrincipal.RecibirDaño(daño, defendiendo);
                ActualizarInterfaz();

                // Verificar si el juego terminó
                if (!jugadorPrincipal.EstaVivo())
                {
                    MessageBox.Show("¡Has sido derrotado! El juego ha terminado.", "Game Over",
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        // Método para cuando el paje recibe daño (ejemplo de uso)
        public void PajeRecibeDaño(int daño)
        {
            if (paje != null)
            {
                paje.RecibirDaño(daño);
                ActualizarInterfaz();

                if (paje.EstaNoqueado)
                {
                    MessageBox.Show($"¡{paje.Nombre} ha sido noqueado!", "Paje Noqueado",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Ejemplo de método para curar (cuando el jugador use la acción curar)
        public void UsarCuracion()
        {
            if (jugadorPrincipal != null && paje != null)
            {
                // El jugador se cura
                int curacionJugador = jugadorPrincipal.Curar();

                // El paje se cura (solo si no está noqueado)
                int curacionPaje = paje.RecibirCuracion(random.Next(4, 25));

                // Mostrar mensaje
                string mensaje = $"{jugadorPrincipal.Nombre} se curó {curacionJugador} HP.";
                if (curacionPaje > 0)
                {
                    mensaje += $"\n{paje.Nombre} se curó {curacionPaje} HP.";
                }
                else if (paje.EstaNoqueado)
                {
                    mensaje += $"\n{paje.Nombre} está noqueado y no puede curarse.";
                }

                MessageBox.Show(mensaje, "Curación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarInterfaz();
            }
        }

        private string PreguntarPersonaje()
        {
            var resultado = MessageBox.Show("¿Con quién querés jugar? \n\nSí = Rick\nNo = Morty", "Elegí personaje", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                return "Rick";
            }
            else
            {
                return "Morty";
            }
        }

        private void CargarUno()
        {
            if (listaMonstruos.Count == 0)
            {
                // No hay más monstruos, el jugador gana
                MessageBox.Show("¡Felicidades! Has derrotado a todos los monstruos. ¡Has ganado!", "¡Victoria!",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;
            }

            int indiceAleatorio = random.Next(listaMonstruos.Count);

            // Obtener el monstruo y eliminarlo de la lista principal
            Monstruo seleccionado = listaMonstruos[indiceAleatorio];
            seleccionado.VidaActual = seleccionado.Vida; // Inicializar vida actual
            atacantes.Add(seleccionado);
            listaMonstruos.RemoveAt(indiceAleatorio);

            // Mostrar imagen
            CargarImagenMonstruoUnico();
        }

        private void CargarImagenMonstruoUnico()
        {
            if (atacantes.Count > 0)
            {
                string nombreMonstruo = atacantes[0].Nombre;
                string rutaImagen = ObtenerRutaImagen(nombreMonstruo);

                try
                {
                    if (File.Exists(rutaImagen))
                    {
                        pic_mst1.Image = Image.FromFile(rutaImagen);
                        pic_mst1.SizeMode = PictureBoxSizeMode.Zoom;
                        pic_mst1.BackColor = Color.Transparent;
                        pic_mst1.Parent = pic_Fondo;
                        pic_mst1.Visible = true;
                        pic_mst1.Tag = atacantes[0];
                    }
                    else
                    {
                        pic_mst1.Image = null;
                        MessageBox.Show($"No se encontró la imagen para {nombreMonstruo}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen de {nombreMonstruo}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ObtenerRutaImagen(string nombreMonstruo)
        {
            // Mapear los nombres de los monstruos a sus rutas de imágenes
            switch (nombreMonstruo)
            {
                case "Evil Morty":
                    return @"images/Morty_M.png";
                case "Rick Prime":
                    return @"images/Ryck_P.png";
                case "Cornvelious":
                    return @"images/Cornvelious_D.png";
                default:
                    return @"images/Rand.png";
            }
        }

        private void CargarMonstruos()
        {
            if (!File.Exists(@"monsters/monstruos.txt"))
            {
                MessageBox.Show("El archivo de monstruos no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lineas = File.ReadAllLines(@"monsters/monstruos.txt");

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');

                if (partes.Length == 4 &&
                    int.TryParse(partes[0], out int vida) &&
                    int.TryParse(partes[2], out int ataqueMin) &&
                    int.TryParse(partes[3], out int ataqueMax))
                {
                    string nombre = partes[1].Trim();

                    Monstruo monstruo = new Monstruo
                    {
                        Nombre = nombre,
                        Vida = vida,
                        VidaActual = vida, // Inicializar vida actual
                        AtaqueMin = ataqueMin,
                        AtaqueMax = ataqueMax
                    };

                    listaMonstruos.Add(monstruo);
                }
                else
                {
                    MessageBox.Show($"Línea inválida: {linea}", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ActualizarMonstruosEnPantalla()
        {
            if (atacantes.Count > 0)
            {
                mst1_name.Text = atacantes[0].Nombre;
                mst1_live.Text = $"HP: {atacantes[0].VidaActual}/{atacantes[0].Vida}";
            }
        }

        private void turno(string accion)
        {
            if (atacantes.Count == 0) return;

            string mensajeTurno = "=== TURNO ===\n";
            Monstruo monstruoActual = atacantes[0];

            // 1. TURNO DEL JUGADOR PRINCIPAL
            if (accion == "golpe")
            {
                int daño = jugadorPrincipal.Atacar();
                monstruoActual.RecibirDaño(daño);
                mensajeTurno += $"{jugadorPrincipal.Nombre} ataca a {monstruoActual.Nombre} por {daño} HP.\n";
                defendiendoEsteTurno = false;
            }
            else if (accion == "suero")
            {
                int curacionJugador = jugadorPrincipal.Curar();
                int curacionPaje = paje.RecibirCuracion(random.Next(4, 25));
                mensajeTurno += $"{jugadorPrincipal.Nombre} se curó {curacionJugador} HP.\n";
                if (curacionPaje > 0)
                {
                    mensajeTurno += $"{paje.Nombre} se curó {curacionPaje} HP.\n";
                }
                else if (paje.EstaNoqueado)
                {
                    mensajeTurno += $"{paje.Nombre} está noqueado y no puede curarse.\n";
                }
                defendiendoEsteTurno = false;
            }
            else if (accion == "berserker")
            {
                int daño = jugadorPrincipal.AtaqueDosManos();
                monstruoActual.RecibirDaño(daño);
                mensajeTurno += $"{jugadorPrincipal.Nombre} usa ataque a dos manos contra {monstruoActual.Nombre} por {daño} HP.\n";
                mensajeTurno += $"{jugadorPrincipal.Nombre} recibirá 50% más daño el próximo turno.\n";
                defendiendoEsteTurno = false;
            }
            else if (accion == "burla")
            {
                mensajeTurno += $"{jugadorPrincipal.Nombre} se prepara para defenderse.\n";
                defendiendoEsteTurno = true;
            }

            // 2. TURNO DEL PAJE (si está vivo y el monstruo aún está vivo)
            if (monstruoActual.EstaVivo() && paje.PuedeActuar())
            {
                int dañoPaje = paje.AtacarAutomatico();
                monstruoActual.RecibirDaño(dañoPaje);
                mensajeTurno += $"{paje.Nombre} ataca a {monstruoActual.Nombre} por {dañoPaje} HP.\n";
            }
            else if (!paje.PuedeActuar() && monstruoActual.EstaVivo())
            {
                mensajeTurno += $"{paje.Nombre} está noqueado y no puede atacar.\n";
            }

            // Verificar si el monstruo murió
            if (!monstruoActual.EstaVivo())
            {
                mensajeTurno += $"\n¡{monstruoActual.Nombre} ha sido derrotado!\n";
                atacantes.RemoveAt(0);

                // Mostrar mensaje del turno antes de cargar nuevo monstruo
                MessageBox.Show(mensajeTurno, "Resultado del Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar nuevo monstruo si hay disponibles
                CargarUno();
                ActualizarMonstruosEnPantalla();
                ActualizarInterfaz();
                return;
            }

            // 3. TURNO DEL MONSTRUO (si está vivo)
            if (monstruoActual.EstaVivo())
            {
                // Decidir a quién atacar (aleatorio entre jugador y paje si el paje está vivo)
                bool atacarJugador = true;

                if (paje.PuedeActuar())
                {
                    atacarJugador = random.Next(2) == 0; // 50% de probabilidad cada uno
                }

                int dañoMonstruo = monstruoActual.Atacar();

                if (atacarJugador)
                {
                    jugadorPrincipal.RecibirDaño(dañoMonstruo, defendiendoEsteTurno);
                    if (defendiendoEsteTurno)
                    {
                        mensajeTurno += $"{monstruoActual.Nombre} ataca a {jugadorPrincipal.Nombre} por {dañoMonstruo} HP (reducido 50% por defensa).\n";
                    }
                    else
                    {
                        mensajeTurno += $"{monstruoActual.Nombre} ataca a {jugadorPrincipal.Nombre} por {dañoMonstruo} HP.\n";
                    }

                    if (!jugadorPrincipal.EstaVivo())
                    {
                        mensajeTurno += "\n¡Has sido derrotado! El juego ha terminado.\n";
                        MessageBox.Show(mensajeTurno, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                        return;
                    }
                }
                else
                {
                    paje.RecibirDaño(dañoMonstruo);
                    mensajeTurno += $"{monstruoActual.Nombre} ataca a {paje.Nombre} por {dañoMonstruo} HP.\n";

                    if (paje.EstaNoqueado)
                    {
                        mensajeTurno += $"¡{paje.Nombre} ha sido noqueado!\n";
                    }
                }
            }

            // Resetear el estado de defensa para el próximo turno
            defendiendoEsteTurno = false;

            // Actualizar interfaz y mostrar resultado del turno
            ActualizarInterfaz();
            MessageBox.Show(mensajeTurno, "Resultado del Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label_second_Click(object sender, EventArgs e)
        {
        }

        private void pic_second_Click(object sender, EventArgs e)
        {
        }

        private void pic_main_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turno("burla");
        }

        private void btn_golpe_Click(object sender, EventArgs e)
        {
            turno("golpe");
        }

        private void btn_suero_Click(object sender, EventArgs e)
        {
            turno("suero");
        }

        private void btn_berserker_Click(object sender, EventArgs e)
        {
            turno("berserker");
        }

        private void mst1_name_Click(object sender, EventArgs e)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace totito
{
    public partial class Form1 : Form
    {
        // Variables globales para guardar los nombres de los jugadores
        string jugador1 = "";
        string jugador2 = "";

        // Constructor del formulario: Es lo primero que se ejecuta al abrir la ventana
        public Form1()
        {
            InitializeComponent(); // Carga todos los botones, labels y paneles visuales
            panel4.Visible = false; // Oculta el panel del tablero hasta que le den a "Jugar"
        }

        // Evento del botón "JUGAR"
        private void button1_Click(object sender, EventArgs e)
        {
            Juego(); // Llama a la función principal para iniciar la partida
        }

        // Configura todo lo necesario para empezar una nueva partida
        public void Juego()
        {
            // Guarda los nombres escritos en los cuadros de texto
            jugador1 = textBox1.Text;
            jugador2 = textBox2.Text;

            // Genera un número aleatorio (0 o 1) para decidir quién usa la X y quién la O
            Random rndFigura = new Random();
            int figura = rndFigura.Next(2);

            // Genera otro número aleatorio (0 o 1) para decidir quién empieza la partida
            Random rndJugador = new Random();
            int jugador = rndJugador.Next(2);

            // Asigna los nombres en pantalla dependiendo del jugador que inicie
            if (jugador == 0)
            {
                label5.Text = jugador1;
                label6.Text = jugador2;
            }
            else
            {
                label6.Text = jugador1;
                label5.Text = jugador2;
            }

            // Asigna la figura (X u O) dependiendo del número aleatorio anterior
            if (figura == 0)
            {
                label9.Text = "X";
                label8.Text = "O";
                turno(1); // Le da el turno inicial al jugador 1
            }
            else
            {
                label8.Text = "X";
                label9.Text = "O";
                turno(2); // Le da el turno inicial al jugador 2
            }

            // Oculta el panel de registro (nombres) y muestra el panel del tablero para jugar
            panel1.Visible = false;
            panel4.Visible = true;

            // Define qué figura ("X" u "O") es la que se va a colocar en el primer clic
            if (label19.Text == "Turno")
            {
                label15.Text = label9.Text;
            }
            else
            {
                label15.Text = label8.Text;
            }
        }

        // Resalta visualmente (con texto en negrita) de quién es el turno actual
        public void turno(int valor)
        {
            if (valor == 1)
            {
                label19.Text = "Turno";
                label18.Text = "";
                label19.Font = new System.Drawing.Font(label19.Font, FontStyle.Bold);
            }
            else
            {
                label18.Text = "Turno";
                label19.Text = "";
                label18.Font = new System.Drawing.Font(label18.Font, FontStyle.Bold);
            }
        }

        // Alterna el turno entre los jugadores después de cada movimiento
        public void cambioTurno()
        {
            if (label19.Text == "Turno")
            {
                // Si era el turno del Jugador 1, se lo pasa al Jugador 2
                label18.Text = "Turno";
                label19.Text = "";
                label15.Text = label8.Text; // Prepara la figura del Jugador 2 para el próximo clic
            }
            else
            {
                // Si era el turno del Jugador 2, se lo pasa al Jugador 1
                label19.Text = "Turno";
                label18.Text = "";
                label15.Text = label9.Text; // Prepara la figura del Jugador 1 para el próximo clic
            }
        }

        // Función auxiliar que revisa si 3 botones tienen el mismo texto (X u O) y no están vacíos
        private bool MismaFigura(Button b1, Button b2, Button b3)
        {
            return (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "");
        }

        // Verifica si alguien ya logró hacer línea de 3
        public bool ganador()
        {
            string figuraGanadora = "";

            // 1. Revisar las 3 Filas horizontales
            if (MismaFigura(button2, button4, button3)) figuraGanadora = button2.Text;
            else if (MismaFigura(button7, button6, button5)) figuraGanadora = button7.Text;
            else if (MismaFigura(button10, button9, button8)) figuraGanadora = button10.Text;

            // 2. Revisar las 3 Columnas verticales
            else if (MismaFigura(button2, button7, button10)) figuraGanadora = button2.Text;
            else if (MismaFigura(button4, button6, button9)) figuraGanadora = button4.Text;
            else if (MismaFigura(button3, button5, button8)) figuraGanadora = button3.Text;

            // 3. Revisar las 2 Diagonales
            else if (MismaFigura(button2, button6, button8)) figuraGanadora = button2.Text;
            else if (MismaFigura(button3, button6, button10)) figuraGanadora = button3.Text;

            // Si encontró una figura ganadora (es decir, ya no está en blanco "")
            if (figuraGanadora != "")
            {
                // Identificar a quién le pertenece esa figura para saber su nombre
                string nombreGanador = "";
                if (label9.Text == figuraGanadora)
                {
                    nombreGanador = label5.Text; // Fue el Jugador 1
                }
                else
                {
                    nombreGanador = label6.Text; // Fue el Jugador 2
                }

                // Muestra los mensajes de victoria y bloquea el tablero
                label20.Text = "¡Ganador: " + nombreGanador + "!";
                MessageBox.Show("¡Felicidades " + nombreGanador + "!", "Fin del Juego");
                DesactivarTablero();
                return true; // Retorna 'verdadero' porque sí hubo un ganador
            }

            return false; // Retorna 'falso' porque nadie ha ganado todavía
        }

        // Bloquea todos los botones para que no puedan seguir jugando si alguien ya ganó o empataron
        public void DesactivarTablero()
        {
            button2.Enabled = false; button4.Enabled = false; button3.Enabled = false;
            button7.Enabled = false; button6.Enabled = false; button5.Enabled = false;
            button10.Enabled = false; button9.Enabled = false; button8.Enabled = false;
        }

        // Verifica si ya se usaron las 9 casillas del tablero
        private bool TableroLleno()
        {
            // Retorna 'true' si TODOS los botones tienen alguna letra adentro
            if (button2.Text != "" && button4.Text != "" && button3.Text != "" &&
                button7.Text != "" && button6.Text != "" && button5.Text != "" &&
                button10.Text != "" && button9.Text != "" && button8.Text != "")
            {
                return true;
            }

            return false; // Retorna 'false' si aún queda al menos un botón en blanco
        }

        // ==============================================================================
        // EVENTOS DE LOS BOTONES DEL TABLERO (Del botón 2 al 10)
        // Todos siguen la misma lógica: Marcan casilla, revisan victoria, empate y turno
        // ==============================================================================

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = label15.Text; // Escribe la X o la O correspondiente
            button2.Enabled = false;     // Desactiva este botón para que no lo presionen otra vez

            // Revisamos si con este movimiento se formó una línea de 3
            bool hayGanador = ganador();

            // Si nadie ha ganado todavía, revisamos si se empató o si el juego sigue
            if (hayGanador == false)
            {
                if (TableroLleno() == true) // ¿Se llenó el tablero sin ganadores?
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    // Si no hay ganador ni empate, el juego continúa y cambiamos de jugador
                    cambioTurno();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = label15.Text;
            button4.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = label15.Text;
            button3.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = label15.Text;
            button7.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = label15.Text;
            button6.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = label15.Text;
            button5.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = label15.Text;
            button10.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = label15.Text;
            button9.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = label15.Text;
            button8.Enabled = false;

            bool hayGanador = ganador();

            if (hayGanador == false)
            {
                if (TableroLleno() == true)
                {
                    label20.Text = "¡Es un Empate!";
                    MessageBox.Show("El tablero se ha llenado. ¡Nadie gana!", "Empate");
                }
                else
                {
                    cambioTurno();
                }
            }
        }
    }
}
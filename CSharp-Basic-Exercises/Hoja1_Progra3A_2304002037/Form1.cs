using System;
using System.Windows.Forms;

namespace Hoja1_Progra3A_2304002037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- INICIO EJERCICIO #1: Teléfono ---
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtenemos el texto ingresado y se lo pasamos al método
            String numero = textBox1.Text;
            // El resultado devuelto se asigna a la etiqueta
            label2.Text = TipoTelefonoMetodo(numero);
        }

        public string TipoTelefonoMetodo(String TipoTelefono)
        {
            // Calculamos la cantidad de dígitos del número ingresado
            int condicion = TipoTelefono.Length;

            // Evaluamos la longitud para determinar el mensaje a retornar
            if (condicion <= 6)
            {
                return "Ingrese un número de 7 digitos o más.";
            }
            else if (condicion == 7)
            {
                return "Su número es fijo o local.";
            }
            else if (condicion == 8)
            {
                return "Ingrese un número válido o verifique los dígitos.";
            }
            else if (condicion == 9)
            {
                return "Su número es móvil.";
            }
            else
            {
                return "Su número es internacional.";
            }
        }
        // --- FIN EJERCICIO #1 ---


        // --- INICIO EJERCICIO #2: Vocal o Consonante ---
        private void button2_Click(object sender, EventArgs e)
        {
            String letra = textBox2.Text;
            label4.Text = TipoCaracter(letra);
        }

        public string TipoCaracter(string caracter)
        {
            // Evaluamos el carácter convirtiéndolo a minúsculas para abarcar tanto mayúsculas como minúsculas
            switch (caracter.ToLower())
            {
                // Si es cualquiera de estas vocales, retorna el mismo mensaje
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    return "El carácter ingresado es: una vocal.";
                case "":
                    return "Ingrese una vocal o consonante.";
                case " ":
                    return "Ingrese un carácter para comprobar.";
                default:
                    return "El carácter ingresado es: una consonante.";
            }
        }
        // --- FIN EJERCICIO #2 ---


        // --- INICIO EJERCICIO #3: Suma 100 a 200 ---
        private void button3_Click(object sender, EventArgs e)
        {
            int conteo = 100;
            int sumatoria = 0;

            // Iniciamos un ciclo que se repite hasta llegar a 200
            while (conteo <= 200)
            {
                // Acumulamos el valor actual en la sumatoria
                sumatoria += conteo;
                // Aumentamos el contador de 1 en 1
                conteo++;
            }

            // Mostramos el resultado total de la suma en la etiqueta
            label6.Text = "La suma de los números del 100 al 200 es: " + sumatoria;
        }
        // --- FIN EJERCICIO #3 ---


        // --- INICIO EJERCICIO #4: Números del 10 al 1 ---
        private void button4_Click(object sender, EventArgs e)
        {
            // Limpiamos la etiqueta antes de empezar a agregar los números
            label9.Text = "";

            int contador = 10;

            // Ciclo que va disminuyendo desde 10 hasta 1
            while (contador >= 1)
            {
                // Agregamos el número actual seguido de una coma y un espacio
                label9.Text += contador + ", ";
                // Disminuimos el contador en 1
                contador--;
            }

            // Eliminamos la última coma y el espacio que sobran al final del texto
            label9.Text = label9.Text.TrimEnd(',', ' ');
        }
        // --- FIN EJERCICIO #4 ---


        // --- INICIO EJERCICIO #5: Números Pares ---
        private void button5_Click(object sender, EventArgs e)
        {
            // Establecemos el texto inicial de la etiqueta
            label12.Text = "Los números pares son: ";

            // Convertimos los valores de texto a números enteros
            int n1 = Convert.ToInt32(textBox3.Text);
            int n2 = Convert.ToInt32(textBox4.Text);

            // Identificamos el número menor y el mayor para definir el rango del ciclo
            int inicio = Math.Min(n1, n2);
            int fin = Math.Max(n1, n2);

            // Recorremos todos los números dentro del rango establecido
            while (inicio <= fin)
            {
                // Comprobamos si el número es par (el residuo de su división entre 2 es 0)
                if (inicio % 2 == 0)
                {
                    // Si es par, lo agregamos a la etiqueta
                    label12.Text += inicio + ", ";
                }
                // Pasamos al siguiente número
                inicio++;
            }

            // Limpiamos la coma final sobrante
            label12.Text = label12.Text.TrimEnd(',', ' ');
        }
        // --- FIN EJERCICIO #5 ---


        // --- INICIO EJERCICIO #6: Puntuación ---
        private void button6_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(textBox5.Text);

            // Validamos que el número ingresado esté dentro del rango lógico de notas (0 a 100)
            if (nota < 0 || nota > 100)
            {
                label15.Text = "Ingrese una nota del 0 al 100.";
            }
            // Evaluamos en qué rango cae la nota para asignar la calificación correspondiente
            else if (nota <= 60)
            {
                label15.Text = "La puntuación es: INACEPTABLE";
            }
            else if (nota <= 80)
            {
                label15.Text = "La puntuación es: ACEPTABLE";
            }
            else
            {
                label15.Text = "La puntuación es: MERITORIO";
            }
        }
        // --- FIN EJERCICIO #6 ---
    }
}
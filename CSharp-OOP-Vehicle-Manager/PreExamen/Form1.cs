using PreExamen.listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExamen
{
    public partial class Form1 : Form
    {
        //Declarar variables
        public lista Marca = new lista();
        public lista Energia = new lista();
        public lista Color = new lista();
        public lista Vehiculos = new lista();
        int contador = 0;
        public vehiculo vehiculo1 = new vehiculo();
        public vehiculo vehiculo2 = new vehiculo();
        public vehiculo vehiculo3 = new vehiculo();
        public Form1()
        {
            InitializeComponent();
            //Agregar listas
            SelectMarca();
            SelectEnergia();
            SelectColor();
            SelectVehiculo();
        }
        //Listas para los combobox
        public void SelectMarca()

        {
            Marca.addList("--- Selecciona marca ---");
            Marca.addList("Toyota");
            Marca.addList("Honda");
            Marca.addList("Kia");
            comboBox1.DataSource = Marca.addList();
        }
        public void SelectEnergia()
        {
            Energia.addList("--- Selecciona energia ---");
            Energia.addList("Gasolina");
            Energia.addList("Electrico");
            //Energia.addList("Kia");
            comboBox2.DataSource = Energia.addList();
        }
        public void SelectColor()
        {
            Color.addList("--- Selecciona color ---");
            Color.addList("Azul");
            Color.addList("Rojo");
            Color.addList("Amarillo");
            comboBox3.DataSource = Color.addList();
        }
        public void SelectVehiculo()
        {
            Vehiculos.addList("--- Selecciona un vehiculo ---");
            Vehiculos.addList("Vehiculo 1");
            Vehiculos.addList("Vehiculo 2");
            Vehiculos.addList("Vehiculo 3");
            comboBox4.DataSource = Vehiculos.addList();
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorcombo = comboBox4.SelectedItem.ToString();
            int indexAlmacen = comboBox4.SelectedIndex;
            String mensaje = " ";
            switch(indexAlmacen) 
            {
                case 1:
                    mensaje = "El numero de placa es: " + vehiculo1.NoPlaca +
                              "\nEl numero de chasis es: " + vehiculo1.NoChasis +
                              "\nLa marca es: " + vehiculo1.Marca +
                              "\nEl tipo de energia es: " + vehiculo1.Energia +
                              "\nEl color es: " + vehiculo1.Color +
                              "\nLa descripcion del vehiculo es: " + vehiculo1.Descripcion;
                    break; 
                case 2:
                    mensaje = "El numero de placa es: " + vehiculo2.NoPlaca +
                              "\nEl numero de chasis es: " + vehiculo2.NoChasis +
                              "\nLa marca es: " + vehiculo2.Marca +
                              "\nEl tipo de energia es: " + vehiculo2.Energia +
                              "\nEl color es: " + vehiculo2.Color +
                              "\nLa descripcion del vehiculo es: " + vehiculo2.Descripcion;
                    break;
                case 3:
                    mensaje = "El numero de placa es: " + vehiculo3.NoPlaca +
                              "\nEl numero de chasis es: " + vehiculo3.NoChasis +
                              "\nLa marca es: " + vehiculo3.Marca +
                              "\nEl tipo de energia es: " + vehiculo3.Energia +
                              "\nEl color es: " + vehiculo3.Color +
                              "\nLa descripcion del vehiculo es: " + vehiculo3.Descripcion;
                    break;
            }
            label10.Text = mensaje;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            switch(contador)
            {
                case 1:
                    vehiculo1.NoPlaca = Convert.ToInt32(textBox1.Text);
                    vehiculo1.NoChasis = Convert.ToInt32(textBox2.Text);
                    vehiculo1.Marca = comboBox1.SelectedItem.ToString();
                    vehiculo1.Energia = comboBox2.SelectedItem.ToString();
                    vehiculo1.Color = comboBox3.SelectedItem.ToString();
                    vehiculo1.Descripcion = textBox3.Text;

                    break;
                case 2:
                    vehiculo2.NoPlaca = Convert.ToInt32(textBox1.Text);
                    vehiculo2.NoChasis = Convert.ToInt32(textBox2.Text);
                    vehiculo2.Marca = comboBox1.SelectedItem.ToString();
                    vehiculo2.Energia = comboBox2.SelectedItem.ToString();
                    vehiculo2.Color = comboBox3.SelectedItem.ToString();
                    vehiculo2.Descripcion = textBox3.Text;
                    break;
                case 3:
                    vehiculo3.NoPlaca = Convert.ToInt32(textBox1.Text);
                    vehiculo3.NoChasis = Convert.ToInt32(textBox2.Text);
                    vehiculo3.Marca = comboBox1.SelectedItem.ToString();
                    vehiculo3.Energia = comboBox2.SelectedItem.ToString();
                    vehiculo3.Color = comboBox3.SelectedItem.ToString();
                    vehiculo3.Descripcion = textBox3.Text;
                    break;
            }
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }
    }
}

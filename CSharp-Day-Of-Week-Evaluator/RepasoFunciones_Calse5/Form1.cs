    namespace RepasoFunciones_Clase5
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                int valorSemana = Convert.ToInt32(textBox1.Text);
                label3.Text = RetornoDiaSemana(valorSemana);

            }
            public string RetornoDiaSemana(int ValorSemana)
            {
                string NombreDia = " ";
                switch (ValorSemana)
                {
                    case 1:
                        NombreDia = "Lunes.";
                        break;
                    case 2:
                        NombreDia = "Martes.";
                        break;
                    case 3:
                        NombreDia = "Miercoles.";
                        break;
                    case 4:
                        NombreDia = "Jueves.";
                        break;
                    case 5:
                        NombreDia = "Viernes.";
                        break;
                    case 6:
                        NombreDia = "Sabado.";
                        break;
                    case 7:
                        NombreDia = "Domingo.";
                        break;
                    default:
                        NombreDia = "Numero ingresado no correspode.";
                        break;
                }

                return NombreDia;
            }
        }
    }
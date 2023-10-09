using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana1V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AsociarEventosBotonesNumeros();
        }
        private void AsociarEventosBotonesNumeros()
        {
            //el codigo asocia a los botones numericos del 1 al 9 usando un bucle for es para manejar el evento click de los botones del 1 al 9
            for (int i = 1; i <= 9; i++)
            {
                string nombreBoton = "num" + i;
                Button boton = Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                if (boton != null)
                {
                    boton.Click -= NumButton_Click; // Desasociar el evento antes de asociarlo nuevamente
                    boton.Click += NumButton_Click;
                }
            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "2";
        }
        //variables
        string operador = "";
        double N1 = 0;
        double N2 = 0;

        public EventHandler NumButton_Click { get; private set; }

        private void clearAll_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = "0";
            N1 = 0;
            N2 = 0;
            operador = "";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            //TextLength = longitud del texto entonces si hay un caracter quiero que sea el cero
            //entonces si la longitud del texto es 1 lo cambia por 0
            if (PantallaResultado.TextLength == 1) PantallaResultado.Text = "0";
            else PantallaResultado.Text = PantallaResultado.Text.Substring(0, PantallaResultado.Text.Length - 1);
            //si no es 1 entonces se resta 1 hasta llegar al numero que queremso que es 0
        }

        private void num1_Click(object sender, EventArgs e)
        {
            //una vez que agregamos un caracter el 0 desaparece y se reemplaza por el numero 1
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "1";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text == "0") PantallaResultado.Text = "";
            PantallaResultado.Text = PantallaResultado.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + ",";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            //cuando haga click en el boton de suma esta parte del codigo va a establecer el operador como suma, guarda el primer numero ingresado de N1 y muestra 0 en la pantallaresultado para permitir el numero siguiente 
            operador = "+";
            N1 = Convert.ToDouble(PantallaResultado.Text);
            PantallaResultado.Text = "0";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            N1 = Convert.ToDouble(PantallaResultado.Text);
            PantallaResultado.Text = "0";
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            N1 = Convert.ToDouble(PantallaResultado.Text);
            PantallaResultado.Text = "0";
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            N1 = Convert.ToDouble(PantallaResultado.Text);
            PantallaResultado.Text = "0";
        }

        private void sigIgual_Click(object sender, EventArgs e)
        {
            //cuando haga click en el boton igual(=) despues de ingresar dos valores y seleccionar la suma convierte el contenido de pantallaresultado a un numero (N2), suma n1 + n2 y muestra el resultado en pantallaresultadon (y asi con todas las operaciones)
            N2 = Convert.ToDouble(PantallaResultado.Text);

            switch (operador)
            {
                //el signo de dolar sirve para interpolar y hacer una cadena de variables (así lo entendí, tengo que investigar más) para juntar dos variables y que sea de lectura más directa
                case "+":
                    PantallaResultado.Text = $"{N1 + N2}";
                    break;
                case "-":
                    PantallaResultado.Text = $"{N1 - N2}";
                    break;
                case "*":
                    PantallaResultado.Text = $"{N1 * N2}";
                    break;
                case "/":
                    PantallaResultado.Text = $"{N1 / N2}";
                    break;
            }
        }
    }
}

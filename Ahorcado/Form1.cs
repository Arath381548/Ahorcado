using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        //Variables utilizadas
        Random aleatorio = new Random();
        int num1;
        int num2;
        int num3;
        string num4;
        int errores = 1;
        int aciertos = 0;
        //Inicia componentes y el juego
        public Form1()
        {
            InitializeComponent();
            numero();
        }
        //Crea los numeros aleatorios y genera la multiplicacion mostrandola en el label1
        public void numero()
        {
            num1 = aleatorio.Next(1, 11);
            num2 = aleatorio.Next(1, 11);

            num3 = num1 * num2;

            label1.Text = num1 + " x " + num2 + " = ";
        }
        //Guarda el valor ingresado del textbox transformandolo a entero y comparandolo con la respuesta
        //Comprueba que el valor sea igual a la respuesta
        //si la respuesta es igual al valor ingresado aumenta el numero de aciertos correctos
        //si la respuesta es diferente al valor ingresado aumenta el numero de aciertos incorrectos y llama al cambio de imagen
        public void validar()
        {
            int comprobar;
            string num4 = textBox1.Text;
            comprobar = Convert.ToInt32(num4);

            if (num3 == comprobar)
            {
                aciertos++;
                label3.Text = Convert.ToString(aciertos);
                textBox1.Text = "";
                numero();
            }
            else
            {
                errores++;
                calcular();
            }

        }
        //Cuenta el numero de errores
        //si se alcanza el error numero 7 reinicia el juego y muestra loss puntos obtenidos antes de termanar el juego
        //si aun no se alcanza el numero 7 se continua el juego
        private void calcular()
        {
            if (errores == 7)
            {
                ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("" + errores);
                MessageBox.Show("Perdiste con " + aciertos + " aciertos\nReiniciando!");
                errores = 1;
                aciertos = 0;
                label3.Text = Convert.ToString(aciertos);
                ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("" + errores);
                textBox1.Text = "";
                numero();
            }
            else
            {
                ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("" + errores);
                textBox1.Text = "";
                numero();
            }
        }
        //Guarda el numero 1 en el textbox
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        //Guarda el numero 2 en el textbox
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        //Guarda el numero 3 en el textbox
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        //Guarda el numero 4 en el textbox
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        //Guarda el numero 5 en el textbox
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        //Guarda el numero 6 en el textbox
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        //Guarda el numero 7 en el textbox
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        //Guarda el numero 8 en el textbox
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        //Guarda el numero 9 en el textbox
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        //Guarda el numero 0 en el textbox
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        //Borra un valor dentro del textbox
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
        //Borra el contenido dentro del textbox
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        //Boton que manda el valor a comprobar con e valor ingresado
        //Manda a comprobar si el textbox esta vacio, si ese es el caso lo manda a agregar un error
        private void Probar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errores++;
                calcular();
            }
            else
            {
                validar();
            }

        }
    }
}
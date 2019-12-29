using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamiento01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos p1 = new Productos();
            Productos p2 = new Productos("Coca Cola", 2.0); // para colocar esto debería tener un constructor que acepte 2 argumentos

            //este es el set
            p1.Nombre = "Borgoña Tabernero";
            p1.Precio = 20;

            //este es el get
            textBox1.Text = p1.Nombre + " tiene precio S/. " + p1.Precio + "\r\n" + p2.Nombre + " tiene precio S/. " + p2.Precio; //\r = retorno de back slash linea

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona("Jenny Rios", 11); 

            //este es el set
            p1.Nombre = "Borrascoso";
            p1.Edad = 4;

            //este es el get
            textBox1.Text = p1.Nombre + " tiene la edad " + p1.Edad + "\r\n" + p2.Nombre + " tiene edad " + p2.Edad; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //una bolsa más grande... usar list

            List<Productos> list = new List<Productos>();
            //adicionando la primera bolsa

            list.Add(new Productos("Mantequilla Laive", 6));
            list.Add(new Productos("Leche Gloria", 4.5));
            list.Add(new Productos("Naranja", 1.5));
            list.Add(new Productos("Galletas Donofrio", 2.0));
            list.Add(new Productos("Chocolate de Menta", 1));

            string msg = "";
            //se recorre una colección con el foreach

            foreach (Productos p in list)
            {
                msg += p.Nombre + " tiene Precio S/. " + p.Precio + "\r\n";
            }

            textBox1.Text = msg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Persona> list = new List<Persona>();
            //adicionando la primera bolsa

            list.Add(new Persona("Luisa", 6));
            list.Add(new Persona("Yombi", 3));
            list.Add(new Persona("Lino", 20));
            list.Add(new Persona("Nathan", 40));
            list.Add(new Persona("Pedro", 10));

            string msg = "";
            //se recorre una colección con el foreach

            foreach (Persona p in list)
            {
                msg += p.Nombre + " tiene la siguiente edad: " + p.Edad + "\r\n";
            }

            textBox1.Text = msg;
        }
    }
}

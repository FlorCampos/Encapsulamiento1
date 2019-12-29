using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamiento02
{
    public partial class Form1 : Form
    {
        private List<Productos> list;

        public Form1()
        {
            InitializeComponent();

            //
            list = new List<Productos>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void poblarListbox()
        {
            //limpiar el listbox
            listBox1.Items.Clear();
            foreach (Productos p in list)
            {
                listBox1.Items.Add(p.Nombre);
            }

            label1.Text = listBox1.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string precio = textBox2.Text;
            bool ok = true;

            if (nombre.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del producto");
            }

            if (ok)
            {
                try
                {
                    double p = Convert.ToDouble(precio);
                    //
                    Productos prod = new Productos(nombre,p);
                    list.Add(prod);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Debe ingresar precio de producto");
                    ok = false;
                }
            }

            if (ok)
            {
                textBox1.Text = "";
                textBox2.Text = "";

                poblarListbox();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            // el indice del listbox señala al mismo indice del list
            if (index != -1)
            {
                Productos p = list[index];

                textBox1.Text = p.Nombre;
                textBox2.Text = p.Precio.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string precio = textBox2.Text;
            bool ok = true;

            if (nombre.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del producto");
            }

            if (ok)
            {
                try
                {
                    double p = Convert.ToDouble(precio);
                    //
                    Productos prod = new Productos(nombre, p);
                    int index = listBox1.SelectedIndex;
                    list.RemoveAt(index);
                    list.Add(prod);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Debe ingresar precio de producto");
                    ok = false;
                }
            }

            if (ok)
            {
                textBox1.Text = "";
                textBox2.Text = "";

                poblarListbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            list.RemoveAt(index);

            textBox1.Text = "";
            textBox2.Text = "";

            poblarListbox();
        }
    }
}

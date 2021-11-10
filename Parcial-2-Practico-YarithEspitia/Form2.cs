using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Practico_YarithEspitia
{
    public partial class Form2 : Form
    {
        string texto;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conductor driver = new Conductor();
            driver.Nombre = textBox2.Text;
            driver.Identificacion = textBox3.Text;

            if (radioButton1.Checked == true)
            {
                driver.Sexo = radioButton1.Text;
            }
            else
            {
                driver.Sexo = radioButton2.Text
            }

            if (radioButton3.Checked == true)
            {
                driver.Afiliacion = radioButton3.Text;
            }
            else
            {
                driver.Afiliacion = radioButton4.Text;
            }

            Vehiculo carro = new Vehiculo();
            carro.Placa = textBox4.Text;
            carro.Marca = textBox5.Text;

            if (radioButton5.Checked == true)
            {
                carro.Tipo = radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                carro.Tipo = radioButton6.Text;
            }
            else 
            {
                carro.Tipo = radioButton7.Text;
            }

            texto = "Vehiculo" + "\n" + "Placa: " + carro.Placa + "\n" + "Tipo: " + carro.Tipo + "\n" + "Marca :" + carro.Marca + "\n" + "Dueño" + "\n" + "Nombre: " + driver.Nombre + "\n" + "Identifiación: " + driver.Identificacion + "\n" + "Sexo: " + driver.Sexo + "\n" + "Afiliación: " + driver.Afiliacion;
            richTextBox1.Text = richTextBox1.Text + texto;

            if (checkBox4.Checked == true)
            {
                checkBox4.BackColor = Color.Red;
            }
            else if (checkBox1.Checked == true)
            {
                checkBox1.BackColor = Color.Red;
            }
            else if (checkBox2.Checked == true)
            {
                checkBox2.BackColor = Color.Red;
            }
            else if (checkBox3.Checked == true)
            {
                checkBox3.BackColor = Color.Red;
            }
            else if (checkBox5.Checked == true)
            {
                checkBox5.BackColor = Color.Red;
            }
            else if (checkBox6.Checked == true)
            {
                checkBox6.BackColor = Color.Red;
            }
            else if (checkBox7.Checked == true)
            {
                checkBox7.BackColor = Color.Red;
            }
            else if (checkBox8.Checked == true)
            {
                checkBox8.BackColor = Color.Red;
            }
            else if (checkBox9.Checked == true)
            {
                checkBox9.BackColor = Color.Red;
            }
            else 
            {
                checkBox10.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false;
        }
    }
}

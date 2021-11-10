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
        DateTime hoy = DateTime.Now;

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
            

            if (radioButton1.Checked == true)
            {
                driver.Sexo = radioButton1.Text;
            }
            else
            {
                driver.Sexo = radioButton2.Text;
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



            if (checkBox4.Checked == true)
            {
                carro.Puesto = checkBox4.Text;
                checkBox4.BackColor = Color.Red;
            }
            else if (checkBox1.Checked == true)
            {
                carro.Puesto = checkBox4.Text;
                checkBox1.BackColor = Color.Red;
            }
            else if (checkBox2.Checked == true)
            {
                carro.Puesto = checkBox4.Text;
                checkBox2.BackColor = Color.Red;
            }
            else if (checkBox3.Checked == true)
            {
                carro.Puesto = checkBox3.Text;
                checkBox3.BackColor = Color.Red;
            }
            else if (checkBox5.Checked == true)
            {
                carro.Puesto = checkBox5.Text;
                checkBox5.BackColor = Color.Red;
            }
            else if (checkBox6.Checked == true)
            {
                carro.Puesto = checkBox6.Text;
                checkBox6.BackColor = Color.Red;
            }
            else if (checkBox7.Checked == true)
            {
                carro.Puesto = checkBox7.Text;
                checkBox7.BackColor = Color.Red;
            }
            else if (checkBox8.Checked == true)
            {
                carro.Puesto = checkBox8.Text;
                checkBox8.BackColor = Color.Red;
            }
            else if (checkBox9.Checked == true)
            {
                carro.Puesto = checkBox9.Text;
                checkBox9.BackColor = Color.Red;
            }
            else
            {
                carro.Puesto = checkBox10.Text;
                checkBox10.BackColor = Color.Red;
            }


            DataGridViewRow fila = new DataGridViewRow();
            fechatxt.Text = hoy.ToString("dd/MM/yy");
            horatxt.Text = hoy.ToString("hh:mm:ss:tt");
            driver.Nombre = textBox2.Text;
            driver.Identificacion = textBox3.Text;
            carro.Placa = textBox4.Text;
            carro.Marca = textBox5.Text;

            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = fechatxt.Text;
            fila.Cells[1].Value = horatxt.Text;
            fila.Cells[2].Value = textBox2.Text;
            fila.Cells[3].Value = textBox3.Text;
            fila.Cells[4].Value = driver.Sexo;
            fila.Cells[5].Value = driver.Afiliacion;
            fila.Cells[6].Value = carro.Tipo;
            fila.Cells[7].Value = textBox4.Text;
            fila.Cells[8].Value = textBox5.Text;
            fila.Cells[9].Value = carro.Puesto;

            dataGridView1.Rows.Add(fila);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
}

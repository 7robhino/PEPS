using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPS_CONTROL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int PosX = 0;
        int PosY = 0;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TERMINAR form1 = new TERMINAR();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string opc = comboBox1.Text; //obtener el valor del combobox
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);

            int dato = cantidad *precio;

            //Adicionar nuevos Renglones
            int n = dataGridView1.Rows.Add();

            //La fecha siempre se imprimira la misma posicion
            dataGridView1.Rows[n].Cells[0].Value = txtFecha.Text;

            //Condicionamos para saber que en celdas iran
            if (opc == "Saldo Inicial")
            {
                dataGridView1.Rows[n].Cells[1].Value = opc;
                dataGridView1.Rows[n].Cells[8].Value =  txtCantidad.Text;
                dataGridView1.Rows[n].Cells[9].Value = txtPrecio.Text;
                dataGridView1.Rows[n].Cells[10].Value = dato;
            }
        }
    }
}
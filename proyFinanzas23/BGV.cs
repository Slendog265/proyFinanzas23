using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyFinanzas23
{
    public partial class BGV : Form
    {
        public BGV()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAnalisisV mAnalisisV = new MAnalisisV();
            mAnalisisV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peraa, perab;
            double Valueaa, Valueab, TVA, TVB;
            int S = dataGridView1.Rows.Add();

            if (accounBox.Text == "" && VaaBox.Text == "" && VabBox.Text == "" && TcaBox.Text == "" 
                && tcbBox.Text == "") 
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView1.Rows.RemoveAt(S);
            }
            else 
            {
                try 
                {
                    Valueaa = double.Parse(VaaBox.Text);
                    Valueab = double.Parse((VabBox.Text));
                    TVA = double.Parse((TcaBox.Text));
                    TVB = double.Parse((tcbBox.Text));
                    peraa = Valueaa * 100 / TVA;
                    peraa = Math.Round(peraa);
                    perab = Valueab * 100 / TVB;
                    perab = Math.Round(perab);



                    dataGridView1.Rows[S].Cells[0].Value = accounBox.Text;
                    dataGridView1.Rows[S].Cells[1].Value = VaaBox.Text;
                    dataGridView1.Rows[S].Cells[2].Value = peraa;
                    dataGridView1.Rows[S].Cells[3].Value = VabBox.Text;
                    dataGridView1.Rows[S].Cells[4].Value = perab;
                
                
                    accounBox.Clear();
                    VaaBox.Clear();
                    VabBox.Clear();
                    TcaBox.Clear();
                    tcbBox.Clear();


                }
                catch 
                {

                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView1.Rows.RemoveAt(S);
                }

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double peraa, perab;
            double Valueaa, Valueab, TVA, TVB;
            int S = dataGridView2.Rows.Add();

            if (accounBox.Text == "" && VaaBox.Text == "" && VabBox.Text == "" 
                && TcaBox.Text == "" && tcbBox.Text == "") 
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView2.Rows.RemoveAt(S);
            }
            else
            {
                try 
                {
                    Valueaa = double.Parse(VaaBox.Text);
                    Valueab = double.Parse((VabBox.Text));
                    TVA = double.Parse((TcaBox.Text));
                    TVB = double.Parse((tcbBox.Text));
                    peraa = Valueaa * 100 / TVA;
                    peraa = Math.Round(peraa);
                    perab = Valueab * 100 / TVB;
                    perab = Math.Round(perab);



                    dataGridView2.Rows[S].Cells[0].Value = accounBox.Text;
                    dataGridView2.Rows[S].Cells[1].Value = VaaBox.Text;
                    dataGridView2.Rows[S].Cells[2].Value = peraa;
                    dataGridView2.Rows[S].Cells[3].Value = VabBox.Text;
                    dataGridView2.Rows[S].Cells[4].Value = perab;

                    accounBox.Clear();
                    VaaBox.Clear();
                    VabBox.Clear();
                    TcaBox.Clear();
                    tcbBox.Clear();
                }
                catch 
                {

                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView2.Rows.RemoveAt(S);
                }
            }

            
        
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                try
                {
                    int n = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(n);
                }
                catch
                {
                    MessageBox.Show("Seleccione una fila con datos que no sea la default");

                }
            }
            else
            {
                MessageBox.Show("No se selecciono nada para eliminar");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell != null)
            {
                try
                {
                    int n = dataGridView2.CurrentCell.RowIndex;
                    dataGridView2.Rows.RemoveAt(n);
                }
                catch
                {
                    MessageBox.Show("Seleccione una fila con datos que no sea la default");

                }
            }
            else
            {
                MessageBox.Show("No se selecciono nada para eliminar");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
    }
}

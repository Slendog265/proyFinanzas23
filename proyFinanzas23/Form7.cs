using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace proyFinanzas23
{
    public partial class resgiBG : Form
    {
        public resgiBG()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mMenu bG = new mMenu();
            bG.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Valueaa, Valueab, ADA, perADa, peraa, perab, TVA, TVB;
            int S = dataGridView1.Rows.Add();
            if (accountBox.Text == "" && vaaBox.Text == "" && vabBox.Text == "" 
                && TotABox.Text == "" && TotbBox.Text == "") 
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView1.Rows.RemoveAt(S);
                
            }
            else
            {
                try 
                {
                    Valueaa = double.Parse(vaaBox.Text);
                    Valueab = double.Parse((vabBox.Text));
                    TVA = double.Parse((TotABox.Text));
                    TVB = double.Parse((TotbBox.Text));
                    ADA = Valueaa - Valueab;
                    perADa = ADA * 100 / Valueab;
                    perADa = Math.Round(perADa);
                    peraa = Valueaa * 100 / TVA;
                    peraa = Math.Round(peraa);
                    perab = Valueab * 100 / TVB;
                    perab = Math.Round(perab);



                    dataGridView1.Rows[S].Cells[0].Value = accountBox.Text;
                    dataGridView1.Rows[S].Cells[1].Value = vaaBox.Text;
                    dataGridView1.Rows[S].Cells[2].Value = vabBox.Text;
                    dataGridView1.Rows[S].Cells[3].Value = ADA;
                    dataGridView1.Rows[S].Cells[4].Value = perADa;
                    dataGridView1.Rows[S].Cells[5].Value = peraa;
                    dataGridView1.Rows[S].Cells[6].Value = perab;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();
                    TotABox.Clear();
                    TotbBox.Clear();
                }
                catch 
                {
                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView1.Rows.RemoveAt(S);

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

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Valueaa, Valueab, ADA, perADa, peraa, perab, TVA, TVB;
            int T = dataGridView2.Rows.Add();

            if (accountBox.Text == "" && vaaBox.Text == "" && vabBox.Text == "" 
                && TotABox.Text == "" && TotbBox.Text == "") 
            {

                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView2.Rows.RemoveAt(T);
            }
            else 
            { 
                try 
                {
                    Valueaa = double.Parse(vaaBox.Text);
                    Valueab = double.Parse((vabBox.Text));
                    TVA = double.Parse((TotABox.Text));
                    TVB = double.Parse((TotbBox.Text));
                    ADA = Valueaa - Valueab;
                    perADa = ADA * 100 / Valueab;
                    perADa = Math.Round(perADa);
                    peraa = Valueaa * 100 / TVA;
                    peraa = Math.Round(peraa);
                    perab = Valueab * 100 / TVB;
                    perab = Math.Round(perab);



                    dataGridView2.Rows[T].Cells[0].Value = accountBox.Text;
                    dataGridView2.Rows[T].Cells[1].Value = vaaBox.Text;
                    dataGridView2.Rows[T].Cells[2].Value = vabBox.Text;
                    dataGridView2.Rows[T].Cells[3].Value = ADA;
                    dataGridView2.Rows[T].Cells[4].Value = perADa;
                    dataGridView2.Rows[T].Cells[5].Value = peraa;
                    dataGridView2.Rows[T].Cells[6].Value = perab;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();
                    TotABox.Clear();
                    TotbBox.Clear();

                }
                catch 
                {
                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView2.Rows.RemoveAt(T);
                }
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentCell != null)
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
    }
}

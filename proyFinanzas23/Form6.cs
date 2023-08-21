using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyFinanzas23
{
    public partial class addSave : System.Windows.Forms.Form
    {
        public addSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mMenu menu = new mMenu();
            menu.ShowDialog();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double Valueaa, Valueab, ADA, perADa, peraa, perab, TVA, TVB;
            int S = estadoResultado.Rows.Add();


            if (VAABox.Text == "" && VAABox.Text == "" && TvaBox.Text == ""
                && TvBBox.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                estadoResultado.Rows.RemoveAt(S);
            }
            else
            {
                try 
                {
                    Valueaa = double.Parse(VAABox.Text);
                    Valueab = double.Parse((VABBox.Text));
                    TVA = double.Parse((TvaBox.Text));
                    TVB = double.Parse((TvBBox.Text));
                    ADA = Valueaa - Valueab;
                    perADa = ADA * 100 / Valueab;
                    perADa = Math.Round(perADa);
                    peraa = Valueaa * 100 / TVA;
                    peraa = Math.Round(peraa);
                    perab = Valueab * 100 / TVB;
                    perab = Math.Round(perab);



                    estadoResultado.Rows[S].Cells[0].Value = accounBox.Text;
                    estadoResultado.Rows[S].Cells[1].Value = VAABox.Text;
                    estadoResultado.Rows[S].Cells[2].Value = VABBox.Text;
                    estadoResultado.Rows[S].Cells[3].Value = ADA;
                    estadoResultado.Rows[S].Cells[4].Value = perADa;
                    estadoResultado.Rows[S].Cells[5].Value = peraa;
                    estadoResultado.Rows[S].Cells[6].Value = perab;

                    accounBox.Clear();
                    VAABox.Clear();
                    VABBox.Clear();
                    TvaBox.Clear();
                    TvBBox.Clear();
                }
                catch 
                {
                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    estadoResultado.Rows.RemoveAt(S);
                }
                
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(estadoResultado.CurrentCell != null) 
            {
                try
                {
                    int n = estadoResultado.CurrentCell.RowIndex;
                    estadoResultado.Rows.RemoveAt(n);
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
            estadoResultado.Rows.Clear();
        }
    }
}

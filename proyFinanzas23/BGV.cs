using Microsoft.Office.Interop.Excel;
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
using objExcel = Microsoft.Office.Interop.Excel;



namespace proyFinanzas23
{
    public partial class BGV : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string path = @"C:\Users\lerne\OneDrive\Escritorio\BGV.xls";
        public BGV()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {

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
            int S = dataGridView1.Rows.Add();

            if (accounBox.Text == "" && VaaBox.Text == "" && VabBox.Text == ""
                && TcaBox.Text == "" && tcbBox.Text == "")
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


        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                objExcel.Application objAplicacion = new objExcel.Application();
                Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

                objAplicacion.Visible = true;

                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;

                    }
                }


                try
                {
                    objLibro.SaveAs(ruta + "\\BalancegeneralVertical.xlsx");
                    objAplicacion.Quit();
                }
                catch
                {

                }
            }
            catch
            {
                MessageBox.Show("No se pueden guardar datos vacios");
            }
        }

    }
}

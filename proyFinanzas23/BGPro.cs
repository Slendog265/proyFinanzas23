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
using objExcel = Microsoft.Office.Interop.Excel;

namespace proyFinanzas23
{
    public partial class BGPro : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public BGPro()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            int S = dataGridView1.Rows.Add();
            if (textBox1.Text == "" && maskedTextBox1.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView1.Rows.RemoveAt(S);

            }
            else
            {
                try
                {

                    dataGridView1.Rows[S].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[S].Cells[1].Value = maskedTextBox1.Text;


                    textBox1.Clear();
                    maskedTextBox1.Clear();

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
                    objLibro.SaveAs(ruta + "\\BalanceProforma.xlsx");
                    objAplicacion.Quit();
                }
                catch
                {

                }
            }
            catch
            {
                MessageBox.Show("Error la tabla esta vacia");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

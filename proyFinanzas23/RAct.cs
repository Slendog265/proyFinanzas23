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
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;


namespace proyFinanzas23
{
    public partial class RAct : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public RAct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView1.Rows.Add();
                a = float.Parse(maskedTextBox1.Text);
                b = float.Parse(maskedTextBox2.Text);
                r = a / b;
                dataGridView1.Rows[s].Cells[1].Value = r;

                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView1.Rows.Add();
                a = float.Parse(maskedTextBox1.Text);
                b = float.Parse(maskedTextBox2.Text);
                r = a / b;
                dataGridView1.Rows[s].Cells[2].Value = r;

                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView2.Rows.Add();
                a = float.Parse(maskedTextBox3.Text);
                b = float.Parse(maskedTextBox4.Text);
                r = a / b;
                dataGridView2.Rows[s].Cells[1].Value = r;

                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView2.Rows.Add();
                a = float.Parse(maskedTextBox3.Text);
                b = float.Parse(maskedTextBox4.Text);
                r = a / b;
                dataGridView1.Rows[s].Cells[2].Value = r;

                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button9_Click(object sender, EventArgs e)
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
                    objLibro.SaveAs(ruta + "\\RotaciónActFijos.xlsx");
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                objExcel.Application objAplicacion = new objExcel.Application();
                Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

                objAplicacion.Visible = true;

                foreach (DataGridViewColumn columna in dataGridView2.Columns)
                {
                    objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                    foreach (DataGridViewRow fila in dataGridView2.Rows)
                    {
                        objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;

                    }
                }


                try
                {
                    objLibro.SaveAs(ruta + "\\RotaciónActTot.xlsx");
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

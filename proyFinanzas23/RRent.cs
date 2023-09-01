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
    public partial class RRent : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public RRent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView1.Rows.Add();
                a = float.Parse(maskedTextBox1.Text);
                b = float.Parse(maskedTextBox3.Text);
                r = (a - b) / a;
                dataGridView1.Rows[s].Cells[1].Value = r;

                maskedTextBox1.Clear();
                maskedTextBox3.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView1.Rows.Add();
                a = float.Parse(maskedTextBox1.Text);
                b = float.Parse(maskedTextBox3.Text);
                r = (a - b) / a;
                dataGridView1.Rows[s].Cells[2].Value = r;

                maskedTextBox1.Clear();
                maskedTextBox3.Clear();
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
                int s = dataGridView3.Rows.Add();
                a = float.Parse(maskedTextBox6.Text);
                b = float.Parse(maskedTextBox2.Text);
                r = a / b;
                dataGridView3.Rows[s].Cells[1].Value = r;

                maskedTextBox6.Clear();
                maskedTextBox2.Clear();
            }
            catch
            {

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView3.Rows.Add();
                a = float.Parse(maskedTextBox6.Text);
                b = float.Parse(maskedTextBox2.Text);
                r = a / b;
                dataGridView3.Rows[s].Cells[2].Value = r;

                maskedTextBox6.Clear();
                maskedTextBox2.Clear();
            }
            catch
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, r;
                int s = dataGridView2.Rows.Add();
                a = float.Parse(maskedTextBox4.Text);
                b = float.Parse(maskedTextBox5.Text);
                r = a / b;
                dataGridView2.Rows[s].Cells[2].Value = r;

                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
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
                a = float.Parse(maskedTextBox4.Text);
                b = float.Parse(maskedTextBox5.Text);
                r = a / b;
                dataGridView2.Rows[s].Cells[1].Value = r;

                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
            }
            catch
            {
                MessageBox.Show("Error los valores estan vacios");
            }

        }

        private void button10_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null)
            {
                try
                {
                    int n = dataGridView3.CurrentCell.RowIndex;
                    dataGridView3.Rows.RemoveAt(n);
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

        private void button8_Click(object sender, EventArgs e)
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
                    objLibro.SaveAs(ruta + "\\MargenUtilidadBruta.xlsx");
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

        private void button7_Click(object sender, EventArgs e)
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
                    objLibro.SaveAs(ruta + "\\MargenUtilidadOperativa.xlsx");
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                objExcel.Application objAplicacion = new objExcel.Application();
                Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

                objAplicacion.Visible = true;

                foreach (DataGridViewColumn columna in dataGridView3.Columns)
                {
                    objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                    foreach (DataGridViewRow fila in dataGridView3.Rows)
                    {
                        objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;

                    }
                }


                try
                {
                    objLibro.SaveAs(ruta + "\\MargenUtilidadNeta.xlsx");
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
    }
}

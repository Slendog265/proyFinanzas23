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
    public partial class RFluidez : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public RFluidez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            float a, b, c, r;
            int s = dataGridView1.Rows.Add();
            a = float.Parse(maskedTextBox4.Text);
            b = float.Parse(maskedTextBox5.Text);
            c = float.Parse(maskedTextBox6.Text);
            r = (a - c) / b;
            dataGridView2.Rows[s].Cells[1].Value = r;

            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            float a, b, c, r;
            int s = dataGridView1.Rows.Add();
            a = float.Parse(maskedTextBox4.Text);
            b = float.Parse(maskedTextBox5.Text);
            c = float.Parse(maskedTextBox6.Text);
            r = (a - c) / b;
            dataGridView2.Rows[s].Cells[1].Value = r;

            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell != null)
            {
                try
                {
                    int n = dataGridView1.CurrentCell.RowIndex;
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

        private void button9_Click(object sender, EventArgs e)
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
                objLibro.SaveAs(ruta + "\\ClasificaciónOAp.xlsx");
                objAplicacion.Quit();
            }
            catch
            {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RazonesFinaacieras r = new RazonesFinaacieras();
            r.Show();
        }
    }
}

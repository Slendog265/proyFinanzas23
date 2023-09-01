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
    public partial class ERPro : Form
    {
        int totv;
        float rt;
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public ERPro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int S = dataGridView1.Rows.Add();

            try
            {

                float vu, pv, r;

                vu = float.Parse(maskedTextBox2.Text);
                pv = float.Parse(maskedTextBox3.Text);
                r = vu * pv;

                dataGridView1.Rows[S].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[S].Cells[1].Value = vu;
                dataGridView1.Rows[S].Cells[2].Value = pv;
                dataGridView1.Rows[S].Cells[3].Value = r;







            }
            catch
            {
                MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                dataGridView1.Rows.RemoveAt(S);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totv = 0;
            int S = dataGridView1.Rows.Add();
            int n = dataGridView2.Rows.Add();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totv += Convert.ToInt32(row.Cells["Column3"].Value);

            }

            dataGridView1.Rows[S].Cells[0].Value = "Total";
            dataGridView1.Rows[S].Cells[3].Value = totv;
            rt = totv;

            dataGridView2.Rows[n].Cells[0].Value = "Ingresos Ventas";
            dataGridView2.Rows[n].Cells[1].Value = totv;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (rt == 0)
            {
                MessageBox.Show("No se puede calcular sin unas ventas");
                return;
            }

            float perc, c, ctot, utb, go, pergo, gotot, uto, pergi, gitot, gi, utani, im, utdi, dv, gan, ingvta, provta, im2;
            int n = dataGridView2.Rows.Add();
            int n1 = dataGridView2.Rows.Add();
            int n2 = dataGridView2.Rows.Add();
            int n3 = dataGridView2.Rows.Add();
            int n4 = dataGridView2.Rows.Add();
            int n5 = dataGridView2.Rows.Add();
            int n6 = dataGridView2.Rows.Add();
            int n7 = dataGridView2.Rows.Add();
            int n8 = dataGridView2.Rows.Add();
            int n9 = dataGridView2.Rows.Add();
            ingvta = float.Parse(maskedTextBox1.Text);
            provta = rt;
            c = float.Parse(maskedTextBox4.Text);
            im = float.Parse(textBox2.Text);
            go = float.Parse(maskedTextBox5.Text);
            gi = float.Parse(maskedTextBox6.Text);
            dv = float.Parse(maskedTextBox7.Text);

            perc = c / ingvta;

            ctot = provta * perc;
            utb = provta - ctot;
            pergo = go / ingvta;
            gotot = provta * pergo;
            uto = utb - gotot;
            pergi = gi / ingvta;
            gitot = provta * pergi;
            utani = uto - gitot;
            im2 = utani * im;
            utdi = utani - im2;
            gan = utdi - dv;

            dataGridView2.Rows[n].Cells[0].Value = "Costo Bienes";
            dataGridView2.Rows[n].Cells[1].Value = ctot;
            dataGridView2.Rows[n1].Cells[0].Value = "Utilidad Bruta";
            dataGridView2.Rows[n1].Cells[1].Value = utb;
            dataGridView2.Rows[n2].Cells[0].Value = "Gasto Op";
            dataGridView2.Rows[n2].Cells[1].Value = gotot;
            dataGridView2.Rows[n3].Cells[0].Value = "Utilidad Op";
            dataGridView2.Rows[n3].Cells[1].Value = uto;
            dataGridView2.Rows[n4].Cells[0].Value = "Gasto Interes";
            dataGridView2.Rows[n4].Cells[1].Value = gitot;
            dataGridView2.Rows[n5].Cells[0].Value = "Uti antes Impuestos";
            dataGridView2.Rows[n5].Cells[1].Value = utani;
            dataGridView2.Rows[n6].Cells[0].Value = "Impuestos";
            dataGridView2.Rows[n6].Cells[1].Value = im2;
            dataGridView2.Rows[n7].Cells[0].Value = "Uti desp Impuestos";
            dataGridView2.Rows[n7].Cells[1].Value = utdi;
            dataGridView2.Rows[n8].Cells[0].Value = "Dividendos";
            dataGridView2.Rows[n8].Cells[1].Value = dv;
            dataGridView2.Rows[n9].Cells[0].Value = "Ganancia o perdida";
            dataGridView2.Rows[n9].Cells[1].Value = gan;






        }



        private void button4_Click(object sender, EventArgs e)
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
                    objLibro.SaveAs(ruta + "\\PronosticoVentas.xlsx");
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

        private void button5_Click(object sender, EventArgs e)
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
                    objLibro.SaveAs(ruta + "\\EstadoResultadoPro.xlsx");
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
    }
}

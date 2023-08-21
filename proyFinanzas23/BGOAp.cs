using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace proyFinanzas23
{
    public partial class BGOAp : Form
    {
        public BGOAp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {

            double Valueaa, Valueab, Camb, perApp, perOri, totOri;
            int S = dataGridView1.Rows.Add();
            int n = dataGridView2.Rows.Add();
            if (vaaBox.Text == "" && vabBox.Text == "" && depreERBox.Text == "" && totOriBox.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView1.Rows.RemoveAt(S);
                dataGridView2.Rows.RemoveAt(n);
            }
            else
            {
                try
                {
                    Valueaa = double.Parse(vaaBox.Text);
                    Valueab = double.Parse((vabBox.Text));
                    totOri = double.Parse((totOriBox.Text));
                    Camb = Valueaa - Valueab;
                    dataGridView1.Rows[S].Cells[3].Value = Camb;
                    if (Camb > 0)
                    {
                        perApp = Camb * 100 / totOri;
                        perApp = Math.Round(perApp);
                        dataGridView2.Rows[n].Cells[3].Value = accountBox.Text;
                        dataGridView2.Rows[n].Cells[4].Value = Camb;
                        dataGridView2.Rows[n].Cells[5].Value = perApp;
                        dataGridView1.Rows[S].Cells[5].Value = Camb;
                    }
                    else
                    {
                        Camb = -Camb;
                        perOri = Camb * 100 / totOri;
                        perOri = Math.Round(perOri);
                        dataGridView2.Rows[n].Cells[0].Value = accountBox.Text;
                        dataGridView2.Rows[n].Cells[1].Value = Camb;
                        dataGridView2.Rows[n].Cells[2].Value = perOri;
                        dataGridView1.Rows[S].Cells[4].Value = Camb;

                    }

                    dataGridView1.Rows[S].Cells[0].Value = accountBox.Text;
                    dataGridView1.Rows[S].Cells[1].Value = vaaBox.Text;
                    dataGridView1.Rows[S].Cells[2].Value = vabBox.Text;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();
                    totOriBox.Clear();


                }
                catch
                {

                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView1.Rows.RemoveAt(S);
                    dataGridView2.Rows.RemoveAt(n);

                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Valueaa, Valueab, Camb, perApp, perOri, totOri, TotApp;
            int S = dataGridView1.Rows.Add();
            int n = dataGridView2.Rows.Add();
            if (vaaBox.Text == "" && vabBox.Text == "" && totOriBox.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView1.Rows.RemoveAt(S);
                dataGridView2.Rows.RemoveAt(n);
            }
            else
            {
                try
                {
                    Valueaa = double.Parse(vaaBox.Text);
                    Valueab = double.Parse((vabBox.Text));
                    totOri = double.Parse((totOriBox.Text));
                    Camb = Valueaa - Valueab;
                    dataGridView1.Rows[S].Cells[3].Value = Camb;
                    if (Camb > 0)
                    {
                        perOri = Camb * 100 / totOri;
                        perOri = Math.Round(perOri);
                        dataGridView2.Rows[n].Cells[0].Value = accountBox.Text;
                        dataGridView2.Rows[n].Cells[1].Value = Camb;
                        dataGridView2.Rows[n].Cells[2].Value = perOri;
                        dataGridView1.Rows[S].Cells[4].Value = Camb;
                    }
                    else
                    {
                        Camb = -Camb;
                        perApp = Camb * 100 / totOri;
                        perApp = Math.Round(perApp);
                        dataGridView2.Rows[n].Cells[3].Value = accountBox.Text;
                        dataGridView2.Rows[n].Cells[4].Value = Camb;
                        dataGridView2.Rows[n].Cells[5].Value = perApp;
                        dataGridView1.Rows[S].Cells[5].Value = Camb;

                    }

                    dataGridView1.Rows[S].Cells[0].Value = accountBox.Text;
                    dataGridView1.Rows[S].Cells[1].Value = vaaBox.Text;
                    dataGridView1.Rows[S].Cells[2].Value = vabBox.Text;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();
                    totOriBox.Clear();
                }
                catch
                {

                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis, base o totales");
                    dataGridView1.Rows.RemoveAt(S);
                    dataGridView2.Rows.RemoveAt(n);

                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal Total = 0;
            decimal Tot1 = 0;
            decimal totAc = 0;
            decimal totPc = 0;
            decimal totm = 0;
            decimal totperO = 0;
            decimal totmA = 0;
            decimal totperA = 0;
            double totcnt = 0;
            double o = 0.5;
            int S = dataGridView1.Rows.Add();
            int a = dataGridView2.Rows.Add();
            int c = dataGridView3.Rows.Add();
            int d = dataGridView4.Rows.Add();
            int f = dataGridView5.Rows.Add();


            try 
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Total += Convert.ToDecimal(row.Cells["Origen"].Value);

                }
                dataGridView1.Rows[S].Cells[0].Value = "Total";
                dataGridView1.Rows[S].Cells[4].Value = Total;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Tot1 += Convert.ToDecimal(row.Cells["App"].Value);

                }
                dataGridView1.Rows[S].Cells[5].Value = Tot1;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    totm += Convert.ToDecimal(row.Cells["Money"].Value);

                }

                //try 
                // {
                dataGridView2.Rows[a].Cells[0].Value = "Total";
                dataGridView2.Rows[a].Cells[1].Value = totm;
                //}

                //catch 
                //{
                MessageBox.Show("Los valores que trato de sumar estan incorrectos o son negativos");

                //}


                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    totperO += Convert.ToDecimal(row.Cells["perOri"].Value);



                }

                dataGridView2.Rows[a].Cells[2].Value = totperO;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    totmA += Convert.ToDecimal(row.Cells["Moneyapp"].Value);

                }

                //try
                //{
                dataGridView2.Rows[a].Cells[4].Value = totmA;
                //}
                //catch 
                //{
                MessageBox.Show("Los valores que trato de sumar estan incorrectos o son negativos");

                //}

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    totperA += Convert.ToDecimal(row.Cells["perApp"].Value);

                }

                dataGridView2.Rows[a].Cells[5].Value = totperA;

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    totAc += Convert.ToDecimal(row.Cells["monAct"].Value);
                }
                dataGridView3.Rows[c].Cells[0].Value = "Total";
                dataGridView3.Rows[c].Cells[1].Value = totAc;

                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    totPc += Convert.ToDecimal(row.Cells["monPas"].Value);
                }
                dataGridView4.Rows[d].Cells[0].Value = "Total";
                dataGridView4.Rows[d].Cells[1].Value = totPc;

                totcnt = Convert.ToDouble(totAc - totPc);
                dataGridView5.Rows[f].Cells[0].Value = totcnt;
            }
            catch {
                MessageBox.Show("Los valores que trato de sumar estan incorrectos o son negativos");
            }

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double camb, valueaa, valueab;
            int c = dataGridView3.Rows.Add();
            if (vaaBox.Text == "" && vabBox.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView3.Rows.RemoveAt(c);

            }
            else
            {
                try
                {
                    valueaa = double.Parse(vaaBox.Text);
                    valueab = double.Parse(vabBox.Text);
                    camb = valueaa - valueab;

                    dataGridView3.Rows[c].Cells[0].Value = accountBox.Text;
                    dataGridView3.Rows[c].Cells[1].Value = camb;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();


                }
                catch
                {
                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis o base");
                    dataGridView3.Rows.RemoveAt(c);

                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double camb, valueaa, valueab;
            int c = dataGridView4.Rows.Add();
            if (vaaBox.Text == "" && vabBox.Text == "")
            {
                MessageBox.Show("El dato ingresado esta vacio o es incorrecto");
                dataGridView4.Rows.RemoveAt(c);

            }
            else
            {
                try
                {
                    valueaa = double.Parse(vaaBox.Text);
                    valueab = double.Parse(vabBox.Text);
                    camb = valueaa - valueab;
                    dataGridView4.Rows[c].Cells[0].Value = accountBox.Text;
                    dataGridView4.Rows[c].Cells[1].Value = camb;

                    accountBox.Clear();
                    vaaBox.Clear();
                    vabBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Escriba un valor numerico en las casillas Valor año analisis o base");
                    dataGridView4.Rows.RemoveAt(c);
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            accountBox.Clear();
            vaaBox.Clear();
            vabBox.Clear();
            totOriBox.Clear();
            depreERBox.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Seleccione un fila con datos que no sea la default");
                }

            }
            else
            {
                MessageBox.Show("No se selecciono nada para eliminar");
            }
        }

        private void button11_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Seleccione un fila con datos que no sea la default");
                }
            }
            else
            {
                MessageBox.Show("No se selecciono nada para eliminar");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentCell != null)
            {
                try
                {
                    int n = dataGridView4.CurrentCell.RowIndex;
                    dataGridView4.Rows.RemoveAt(n);
                }
                catch
                {
                    MessageBox.Show("Seleccione un fila con datos que no sea la default");
                }
            }
            else
            {
                MessageBox.Show("No se selecciono nada para eliminar");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            double valuean, Valuebn, totOAP, perApp, perOri, depre, Uai, cambActfDF, pagoDividendo, fe;
            int n = dataGridView2.Rows.Add();

            if (uaiiERBox.Text == "")
            {
                try
                {
                    valuean = double.Parse(vaaBox.Text);
                    Valuebn = double.Parse(vabBox.Text);
                    depre = double.Parse(depreERBox.Text);
                    cambActfDF = valuean + depre - Valuebn;
                    totOAP = double.Parse(totOriBox.Text);
                    perOri = depre * 100 / totOAP;
                    perOri = Math.Round(perOri);
                    perApp = cambActfDF * 100 / totOAP;
                    perApp = Math.Round(perApp);
                    dataGridView2.Rows[n].Cells[3].Value = "Incre Act Fijo";
                    dataGridView2.Rows[n].Cells[4].Value = cambActfDF;
                    dataGridView2.Rows[n].Cells[5].Value = perApp;
                    dataGridView2.Rows[n].Cells[0].Value = "Depreciación";
                    dataGridView2.Rows[n].Cells[1].Value = depre;
                    dataGridView2.Rows[n].Cells[2].Value = perOri;
                }
                catch
                {
                    MessageBox.Show("Escriba un valor numerico que cumpla la formula");
                    dataGridView2.Rows.RemoveAt(n);
                }
                
            }
            else
            {
                if (depreERBox.Text == "")
                {
                    try
                    {
                        valuean = double.Parse(vaaBox.Text);
                        Valuebn = double.Parse(vabBox.Text);
                        Uai = double.Parse(uaiiERBox.Text);
                        totOAP = double.Parse(totOriBox.Text);
                        cambActfDF = Uai - valuean + Valuebn;
                        perApp = cambActfDF * 100 / totOAP;
                        perApp = Math.Round(perApp);
                        perOri = Uai * 100 / totOAP;
                        perOri = Math.Round(perOri);
                        dataGridView2.Rows[n].Cells[3].Value = "Pago Dividendos";
                        dataGridView2.Rows[n].Cells[4].Value = cambActfDF;
                        dataGridView2.Rows[n].Cells[5].Value = perApp;
                        dataGridView2.Rows[n].Cells[0].Value = "Utilidad Neta";
                        dataGridView2.Rows[n].Cells[1].Value = Uai;
                        dataGridView2.Rows[n].Cells[2].Value = perOri;
                    }
                    catch
                    {
                        MessageBox.Show("Escriba un valor numerico que cumpla la formula");
                        dataGridView2.Rows.RemoveAt(n);

                    }
                    

                }
                else
                {
                    if (vaaBox.Text == "" && vabBox.Text == "")
                    {
                        try
                        {
                            
                            dataGridView2.Rows[n].Cells[0].Value = "Flujo Operación";

                        }
                        catch
                        {
                            MessageBox.Show("Escriba un valor numerico que cumpla la formula");
                            dataGridView2.Rows.RemoveAt(n);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No hay ningun dato para realizar un calculo");
                        dataGridView2.Rows.RemoveAt(n);
                    }
                }

            }
        }
    }
}

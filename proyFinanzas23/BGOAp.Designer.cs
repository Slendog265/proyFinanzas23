namespace proyFinanzas23
{
    partial class BGOAp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            App = new DataGridViewTextBoxColumn();
            button3 = new Button();
            accountBox = new TextBox();
            vabBox = new TextBox();
            vaaBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            Ori = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            perOri = new DataGridViewTextBoxColumn();
            Appli = new DataGridViewTextBoxColumn();
            Moneyapp = new DataGridViewTextBoxColumn();
            perApp = new DataGridViewTextBoxColumn();
            totOriBox = new TextBox();
            label4 = new Label();
            depreERBox = new TextBox();
            label5 = new Label();
            button5 = new Button();
            button6 = new Button();
            dataGridView3 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            monAct = new DataGridViewTextBoxColumn();
            pasCir = new DataGridViewTextBoxColumn();
            moneyPC = new DataGridViewTextBoxColumn();
            CNtra = new DataGridViewTextBoxColumn();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            button11 = new Button();
            uaiiERBox = new TextBox();
            label6 = new Label();
            button9 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Origen, App });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(4, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(918, 259);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cuentas";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Valor año-analisis";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor año-base";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Cambios";
            Column4.Name = "Column4";
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            // 
            // App
            // 
            App.HeaderText = "Aplicación";
            App.Name = "App";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(141, 117);
            button3.Name = "button3";
            button3.Size = new Size(114, 23);
            button3.TabIndex = 4;
            button3.Text = "Agregar Pasivo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // accountBox
            // 
            accountBox.Location = new Point(12, 68);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(100, 23);
            accountBox.TabIndex = 5;
            // 
            // vabBox
            // 
            vabBox.Location = new Point(224, 68);
            vabBox.Name = "vabBox";
            vabBox.Size = new Size(100, 23);
            vabBox.TabIndex = 8;
            // 
            // vaaBox
            // 
            vaaBox.Location = new Point(118, 68);
            vaaBox.Name = "vaaBox";
            vaaBox.Size = new Size(100, 23);
            vaaBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 28);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 11;
            label2.Text = "Valor Año \r\nAnalisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 30);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 12;
            label3.Text = "Valor Año \r\nBase";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 117);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 13;
            button2.Text = "Agregar Activo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(526, 118);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 14;
            button4.Text = "Sumar Columnas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Ori, Money, perOri, Appli, Moneyapp, perApp });
            dataGridView2.Location = new Point(5, 473);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(918, 259);
            dataGridView2.TabIndex = 15;
            // 
            // Ori
            // 
            Ori.HeaderText = "Origen";
            Ori.Name = "Ori";
            // 
            // Money
            // 
            Money.HeaderText = "$";
            Money.Name = "Money";
            // 
            // perOri
            // 
            perOri.HeaderText = "%";
            perOri.Name = "perOri";
            // 
            // Appli
            // 
            Appli.HeaderText = "Aplicación";
            Appli.Name = "Appli";
            // 
            // Moneyapp
            // 
            Moneyapp.HeaderText = "$";
            Moneyapp.Name = "Moneyapp";
            // 
            // perApp
            // 
            perApp.HeaderText = "%";
            perApp.Name = "perApp";
            // 
            // totOriBox
            // 
            totOriBox.Location = new Point(330, 68);
            totOriBox.Name = "totOriBox";
            totOriBox.Size = new Size(100, 23);
            totOriBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(330, 28);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 17;
            label4.Text = "Total Origen \r\ny Aplicación";
            // 
            // depreERBox
            // 
            depreERBox.Location = new Point(436, 68);
            depreERBox.Name = "depreERBox";
            depreERBox.Size = new Size(100, 23);
            depreERBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(436, 28);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 19;
            label5.Text = "Depreciación de\r\nEstado Resultado";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(928, 208);
            button5.Name = "button5";
            button5.Size = new Size(98, 23);
            button5.TabIndex = 20;
            button5.Text = "Borrar Fila";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(526, 147);
            button6.Name = "button6";
            button6.Size = new Size(85, 23);
            button6.TabIndex = 21;
            button6.Text = "Borrar todo";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5, monAct, pasCir, moneyPC, CNtra });
            dataGridView3.Location = new Point(5, 738);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(917, 283);
            dataGridView3.TabIndex = 22;
            // 
            // Column5
            // 
            Column5.HeaderText = "Activos Circulantes";
            Column5.Name = "Column5";
            // 
            // monAct
            // 
            monAct.HeaderText = "Activo Circulante $";
            monAct.Name = "monAct";
            // 
            // pasCir
            // 
            pasCir.HeaderText = "Pasivo Circulante";
            pasCir.Name = "pasCir";
            // 
            // moneyPC
            // 
            moneyPC.HeaderText = "Pasivo Circulante $";
            moneyPC.Name = "moneyPC";
            // 
            // CNtra
            // 
            CNtra.HeaderText = "Capital Neto de Trabajo";
            CNtra.Name = "CNtra";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(20, 20, 20);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(261, 117);
            button7.Name = "button7";
            button7.Size = new Size(122, 47);
            button7.TabIndex = 24;
            button7.Text = "Agregar Activo Capital";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(20, 20, 20);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(395, 117);
            button8.Name = "button8";
            button8.Size = new Size(122, 47);
            button8.TabIndex = 25;
            button8.Text = "Agregar Pasivo Capital";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(20, 20, 20);
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(928, 473);
            button10.Name = "button10";
            button10.Size = new Size(98, 23);
            button10.TabIndex = 27;
            button10.Text = "Borrar Fila";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(20, 20, 20);
            button11.FlatAppearance.BorderColor = Color.Black;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.White;
            button11.Location = new Point(928, 738);
            button11.Name = "button11";
            button11.Size = new Size(98, 23);
            button11.TabIndex = 28;
            button11.Text = "Borrar Fila";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // uaiiERBox
            // 
            uaiiERBox.Location = new Point(584, 68);
            uaiiERBox.Name = "uaiiERBox";
            uaiiERBox.Size = new Size(100, 23);
            uaiiERBox.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(546, 28);
            label6.Name = "label6";
            label6.Size = new Size(183, 30);
            label6.TabIndex = 32;
            label6.Text = "Utilidades antes de Impuestos de \r\n             Estado Resultado";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(20, 20, 20);
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(655, 115);
            button9.Name = "button9";
            button9.Size = new Size(136, 26);
            button9.TabIndex = 33;
            button9.Text = "Calcular Formulas";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(20, 20, 20);
            button12.FlatAppearance.BorderColor = Color.Black;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.White;
            button12.Location = new Point(928, 237);
            button12.Name = "button12";
            button12.Size = new Size(93, 23);
            button12.TabIndex = 34;
            button12.Text = "Guardar";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(20, 20, 20);
            button13.FlatAppearance.BorderColor = Color.Black;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.White;
            button13.Location = new Point(928, 502);
            button13.Name = "button13";
            button13.Size = new Size(93, 23);
            button13.TabIndex = 35;
            button13.Text = "Guardar";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(20, 20, 20);
            button14.FlatAppearance.BorderColor = Color.Black;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.White;
            button14.Location = new Point(928, 767);
            button14.Name = "button14";
            button14.Size = new Size(93, 24);
            button14.TabIndex = 36;
            button14.Text = "Guardar";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // BGOAp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1063, 749);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(label6);
            Controls.Add(uaiiERBox);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(dataGridView3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(depreERBox);
            Controls.Add(label4);
            Controls.Add(totOriBox);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vaaBox);
            Controls.Add(vabBox);
            Controls.Add(accountBox);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1063, 718);
            Name = "BGOAp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BGOAp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox accountBox;
        private TextBox vabBox;
        private TextBox vaaBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn App;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Ori;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn perOri;
        private DataGridViewTextBoxColumn Appli;
        private DataGridViewTextBoxColumn Moneyapp;
        private DataGridViewTextBoxColumn perApp;
        private TextBox totOriBox;
        private Label label4;
        private TextBox depreERBox;
        private Label label5;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private TextBox uaiiERBox;
        private Label label6;
        private Button button9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn monAct;
        private DataGridViewTextBoxColumn pasCir;
        private DataGridViewTextBoxColumn moneyPC;
        private DataGridViewTextBoxColumn CNtra;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}
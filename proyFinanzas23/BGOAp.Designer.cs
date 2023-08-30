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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Origen, App });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(20, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(645, 295);
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
            button3.Location = new Point(231, 90);
            button3.Name = "button3";
            button3.Size = new Size(114, 23);
            button3.TabIndex = 4;
            button3.Text = "Agregar Pasivo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // accountBox
            // 
            accountBox.Location = new Point(125, 49);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(100, 23);
            accountBox.TabIndex = 5;
            // 
            // vabBox
            // 
            vabBox.Location = new Point(337, 49);
            vabBox.Name = "vabBox";
            vabBox.Size = new Size(100, 23);
            vabBox.TabIndex = 8;
            // 
            // vaaBox
            // 
            vaaBox.Location = new Point(231, 49);
            vaaBox.Name = "vaaBox";
            vaaBox.Size = new Size(100, 23);
            vaaBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 16);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 11;
            label2.Text = "Valor Año \r\nAnalisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 18);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 12;
            label3.Text = "Valor Año \r\nBase";
            // 
            // button2
            // 
            button2.Location = new Point(111, 90);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 13;
            button2.Text = "Agregar Activo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(641, 78);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 14;
            button4.Text = "Sumar Columnas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Ori, Money, perOri, Appli, Moneyapp, perApp });
            dataGridView2.Location = new Point(684, 131);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(645, 295);
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
            totOriBox.Location = new Point(443, 49);
            totOriBox.Name = "totOriBox";
            totOriBox.Size = new Size(100, 23);
            totOriBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 16);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 17;
            label4.Text = "Total Origen \r\ny Aplicación";
            // 
            // depreERBox
            // 
            depreERBox.Location = new Point(549, 49);
            depreERBox.Name = "depreERBox";
            depreERBox.Size = new Size(100, 23);
            depreERBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 16);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 19;
            label5.Text = "Depreciación de\r\nEstado Resultado";
            // 
            // button5
            // 
            button5.Location = new Point(567, 432);
            button5.Name = "button5";
            button5.Size = new Size(98, 23);
            button5.TabIndex = 20;
            button5.Text = "Borrar Fila";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(659, 102);
            button6.Name = "button6";
            button6.Size = new Size(85, 23);
            button6.TabIndex = 21;
            button6.Text = "Borrar todo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5, monAct, pasCir, moneyPC, CNtra });
            dataGridView3.Location = new Point(18, 517);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(543, 220);
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
            button7.Location = new Point(373, 78);
            button7.Name = "button7";
            button7.Size = new Size(122, 47);
            button7.TabIndex = 24;
            button7.Text = "Agregar Activo Capital";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(501, 78);
            button8.Name = "button8";
            button8.Size = new Size(122, 47);
            button8.TabIndex = 25;
            button8.Text = "Agregar Pasivo Capital";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1231, 432);
            button10.Name = "button10";
            button10.Size = new Size(98, 23);
            button10.TabIndex = 27;
            button10.Text = "Borrar Fila";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(567, 714);
            button11.Name = "button11";
            button11.Size = new Size(98, 23);
            button11.TabIndex = 28;
            button11.Text = "Borrar Fila";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // uaiiERBox
            // 
            uaiiERBox.Location = new Point(697, 49);
            uaiiERBox.Name = "uaiiERBox";
            uaiiERBox.Size = new Size(100, 23);
            uaiiERBox.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(659, 16);
            label6.Name = "label6";
            label6.Size = new Size(183, 30);
            label6.TabIndex = 32;
            label6.Text = "Utilidades antes de Impuestos de \r\n             Estado Resultado";
            // 
            // button9
            // 
            button9.Location = new Point(771, 102);
            button9.Name = "button9";
            button9.Size = new Size(136, 26);
            button9.TabIndex = 33;
            button9.Text = "Calcular Formulas";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button12
            // 
            button12.Location = new Point(468, 432);
            button12.Name = "button12";
            button12.Size = new Size(93, 23);
            button12.TabIndex = 34;
            button12.Text = "Guardar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1132, 432);
            button13.Name = "button13";
            button13.Size = new Size(93, 23);
            button13.TabIndex = 35;
            button13.Text = "Guardar";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(567, 685);
            button14.Name = "button14";
            button14.Size = new Size(93, 23);
            button14.TabIndex = 36;
            button14.Text = "Guardar";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // BGOAp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1341, 749);
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
            Controls.Add(button1);
            Name = "BGOAp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BGOAp";
            WindowState = FormWindowState.Maximized;
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

        private Button button1;
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
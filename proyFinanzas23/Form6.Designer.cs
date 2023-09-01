namespace proyFinanzas23
{
    partial class addSave
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
            estadoResultado = new DataGridView();
            Cuent = new DataGridViewTextBoxColumn();
            VañoAna = new DataGridViewTextBoxColumn();
            VAñoBase = new DataGridViewTextBoxColumn();
            ADE = new DataGridViewTextBoxColumn();
            perAD = new DataGridViewTextBoxColumn();
            PAñoAn = new DataGridViewTextBoxColumn();
            PAñoBase = new DataGridViewTextBoxColumn();
            accounBox = new TextBox();
            VAABox = new TextBox();
            VABBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calc = new Button();
            TvaBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TvBBox = new TextBox();
            button5 = new Button();
            button3 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)estadoResultado).BeginInit();
            SuspendLayout();
            // 
            // estadoResultado
            // 
            estadoResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            estadoResultado.BackgroundColor = Color.FromArgb(0, 64, 64);
            estadoResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estadoResultado.Columns.AddRange(new DataGridViewColumn[] { Cuent, VañoAna, VAñoBase, ADE, perAD, PAñoAn, PAñoBase });
            estadoResultado.Location = new Point(12, 120);
            estadoResultado.Name = "estadoResultado";
            estadoResultado.RowTemplate.Height = 25;
            estadoResultado.Size = new Size(1023, 480);
            estadoResultado.TabIndex = 1;
            // 
            // Cuent
            // 
            Cuent.HeaderText = "Cuentas";
            Cuent.Name = "Cuent";
            // 
            // VañoAna
            // 
            VañoAna.HeaderText = "Valor Año Analisis";
            VañoAna.Name = "VañoAna";
            // 
            // VAñoBase
            // 
            VAñoBase.HeaderText = "Valor Año Base";
            VAñoBase.Name = "VAñoBase";
            // 
            // ADE
            // 
            ADE.HeaderText = "Aumento Disminución";
            ADE.Name = "ADE";
            // 
            // perAD
            // 
            perAD.HeaderText = "A y D %";
            perAD.Name = "perAD";
            // 
            // PAñoAn
            // 
            PAñoAn.HeaderText = "Analisis %";
            PAñoAn.Name = "PAñoAn";
            // 
            // PAñoBase
            // 
            PAñoBase.HeaderText = "Base %";
            PAñoBase.Name = "PAñoBase";
            // 
            // accounBox
            // 
            accounBox.Location = new Point(12, 91);
            accounBox.Name = "accounBox";
            accounBox.Size = new Size(100, 23);
            accounBox.TabIndex = 2;
            // 
            // VAABox
            // 
            VAABox.Location = new Point(158, 91);
            VAABox.Name = "VAABox";
            VAABox.Size = new Size(100, 23);
            VAABox.TabIndex = 3;
            // 
            // VABBox
            // 
            VABBox.Location = new Point(311, 91);
            VABBox.Name = "VABBox";
            VABBox.Size = new Size(100, 23);
            VABBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 73);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 11;
            label2.Text = "Valor Año Analisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(311, 73);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 12;
            label3.Text = "Valor Año Base";
            // 
            // calc
            // 
            calc.BackColor = Color.FromArgb(20, 20, 20);
            calc.FlatAppearance.BorderColor = Color.Black;
            calc.FlatStyle = FlatStyle.Flat;
            calc.ForeColor = Color.White;
            calc.Location = new Point(779, 91);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 15;
            calc.Text = "Calcular";
            calc.UseVisualStyleBackColor = false;
            calc.Click += calc_Click;
            // 
            // TvaBox
            // 
            TvaBox.Location = new Point(474, 91);
            TvaBox.Name = "TvaBox";
            TvaBox.Size = new Size(100, 23);
            TvaBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(474, 73);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 17;
            label4.Text = "Total Ventas Analisis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(622, 73);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 18;
            label5.Text = "Total Ventas Base";
            // 
            // TvBBox
            // 
            TvBBox.Location = new Point(622, 91);
            TvBBox.Name = "TvBBox";
            TvBBox.Size = new Size(100, 23);
            TvBBox.TabIndex = 19;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(910, 91);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 21;
            button5.Text = "Borrar toda cuenta";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(942, 62);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 20;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(942, 33);
            button6.Name = "button6";
            button6.Size = new Size(93, 23);
            button6.TabIndex = 22;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // addSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(TvBBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TvaBox);
            Controls.Add(calc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(VABBox);
            Controls.Add(VAABox);
            Controls.Add(accounBox);
            Controls.Add(estadoResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "addSave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)estadoResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView estadoResultado;
        private TextBox accounBox;
        private TextBox VAABox;
        private TextBox VABBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calc;
        private DataGridViewTextBoxColumn Cuent;
        private DataGridViewTextBoxColumn VañoAna;
        private DataGridViewTextBoxColumn VAñoBase;
        private DataGridViewTextBoxColumn ADE;
        private DataGridViewTextBoxColumn perAD;
        private DataGridViewTextBoxColumn PAñoAn;
        private DataGridViewTextBoxColumn PAñoBase;
        private TextBox TvaBox;
        private Label label4;
        private Label label5;
        private TextBox TvBBox;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}
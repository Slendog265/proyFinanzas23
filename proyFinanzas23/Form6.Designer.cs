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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // estadoResultado
            // 
            estadoResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estadoResultado.Columns.AddRange(new DataGridViewColumn[] { Cuent, VañoAna, VAñoBase, ADE, perAD, PAñoAn, PAñoBase });
            estadoResultado.Location = new Point(12, 160);
            estadoResultado.Name = "estadoResultado";
            estadoResultado.RowTemplate.Height = 25;
            estadoResultado.Size = new Size(744, 202);
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
            accounBox.Location = new Point(145, 27);
            accounBox.Name = "accounBox";
            accounBox.Size = new Size(100, 23);
            accounBox.TabIndex = 2;
            // 
            // VAABox
            // 
            VAABox.Location = new Point(270, 27);
            VAABox.Name = "VAABox";
            VAABox.Size = new Size(100, 23);
            VAABox.TabIndex = 3;
            // 
            // VABBox
            // 
            VABBox.Location = new Point(401, 27);
            VABBox.Name = "VABBox";
            VABBox.Size = new Size(100, 23);
            VABBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 11;
            label2.Text = "Valor Año Analisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 12;
            label3.Text = "Valor Año Base";
            // 
            // calc
            // 
            calc.Location = new Point(145, 72);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 15;
            calc.Text = "Calcular";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // TvaBox
            // 
            TvaBox.Location = new Point(520, 27);
            TvaBox.Name = "TvaBox";
            TvaBox.Size = new Size(100, 23);
            TvaBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 9);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 17;
            label4.Text = "Total Ventas Analisis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 9);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 18;
            label5.Text = "Total Ventas Base";
            // 
            // TvBBox
            // 
            TvBBox.Location = new Point(640, 27);
            TvBBox.Name = "TvBBox";
            TvBBox.Size = new Size(100, 23);
            TvBBox.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(779, 189);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 21;
            button5.Text = "Borrar toda cuenta";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(789, 160);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 20;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(789, 131);
            button6.Name = "button6";
            button6.Size = new Size(93, 23);
            button6.TabIndex = 22;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // addSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 365);
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
            Controls.Add(button1);
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

        private Button button1;
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
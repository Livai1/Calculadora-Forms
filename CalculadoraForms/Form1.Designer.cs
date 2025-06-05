namespace CalculadoraForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnsoma = new Button();
            btnsubtrair = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            lblResultado = new Label();
            lstHistorico = new ListBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(14, 102);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(54, 41);
            btnsoma.TabIndex = 0;
            btnsoma.Text = "+";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnsubtrair
            // 
            btnsubtrair.Location = new Point(74, 102);
            btnsubtrair.Name = "btnsubtrair";
            btnsubtrair.Size = new Size(54, 41);
            btnsubtrair.TabIndex = 1;
            btnsubtrair.Text = "-";
            btnsubtrair.UseVisualStyleBackColor = true;
            btnsubtrair.Click += btnsubtrair_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(12, 149);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(54, 41);
            btnmultiplicar.TabIndex = 2;
            btnmultiplicar.Text = "x";
            btnmultiplicar.UseVisualStyleBackColor = true;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btndividir
            // 
            btndividir.Location = new Point(74, 149);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(54, 41);
            btndividir.TabIndex = 3;
            btndividir.Text = "÷";
            btndividir.UseVisualStyleBackColor = true;
            btndividir.Click += btndividir_Click;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(12, 26);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 4;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(118, 26);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 62);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(73, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "RESULTADO:";
            // 
            // lstHistorico
            // 
            lstHistorico.FormattingEnabled = true;
            lstHistorico.ItemHeight = 15;
            lstHistorico.Location = new Point(14, 226);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(201, 94);
            lstHistorico.TabIndex = 7;
            lstHistorico.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(74, 326);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(67, 34);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 372);
            Controls.Add(btnLimpar);
            Controls.Add(lstHistorico);
            Controls.Add(lblResultado);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnsubtrair);
            Controls.Add(btnsoma);
            Name = "Form1";
            Text = "CALCULADORA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsoma;
        private Button btnsubtrair;
        private Button btnmultiplicar;
        private Button btndividir;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private Label lblResultado;
        private ListBox lstHistorico;
        private Button btnLimpar;
    }
}

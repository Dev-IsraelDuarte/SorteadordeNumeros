namespace BingoMaster
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
            numMin = new NumericUpDown();
            numMax = new NumericUpDown();
            btnSortear = new Button();
            lblResultado = new Label();
            lstHistorico = new ListBox();
            btnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            SuspendLayout();
            // 
            // numMin
            // 
            numMin.Location = new Point(43, 165);
            numMin.Name = "numMin";
            numMin.Size = new Size(50, 23);
            numMin.TabIndex = 0;
            numMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMax
            // 
            numMax.Location = new Point(43, 209);
            numMax.Name = "numMax";
            numMax.Size = new Size(50, 23);
            numMax.TabIndex = 1;
            numMax.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(101, 256);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(130, 36);
            btnSortear.TabIndex = 2;
            btnSortear.Text = "SORTEAR";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(142, 67);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(46, 45);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "--";
            // 
            // lstHistorico
            // 
            lstHistorico.FormattingEnabled = true;
            lstHistorico.Location = new Point(43, 318);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(260, 94);
            lstHistorico.TabIndex = 4;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(228, 418);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 147);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor entre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 191);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 7;
            label2.Text = "é";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(315, 45);
            label3.TabIndex = 8;
            label3.Text = "Sorteador de Bingo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 479);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(lstHistorico);
            Controls.Add(lblResultado);
            Controls.Add(btnSortear);
            Controls.Add(numMax);
            Controls.Add(numMin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMin;
        private NumericUpDown numMax;
        private Button btnSortear;
        private Label lblResultado;
        private ListBox lstHistorico;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

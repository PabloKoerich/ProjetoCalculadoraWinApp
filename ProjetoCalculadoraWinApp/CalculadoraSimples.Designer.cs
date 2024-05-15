namespace ProjetoCalculadoraWinApp
{
    partial class CalculadoraSimples
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
            groupBox1 = new GroupBox();
            txtPrimeiroNumero = new TextBox();
            txtSegundoNumero = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdbDivisao = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbAdicao = new RadioButton();
            btnCalcular = new Button();
            btnLimpar = new Button();
            ListaDeHistorico = new ListBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrimeiroNumero);
            groupBox1.Controls.Add(txtSegundoNumero);
            groupBox1.Controls.Add(txtResultado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(101, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe os Valores:";
            // 
            // txtPrimeiroNumero
            // 
            txtPrimeiroNumero.BorderStyle = BorderStyle.FixedSingle;
            txtPrimeiroNumero.Font = new Font("Arial Narrow", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimeiroNumero.Location = new Point(169, 24);
            txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            txtPrimeiroNumero.Size = new Size(60, 26);
            txtPrimeiroNumero.TabIndex = 0;
            // 
            // txtSegundoNumero
            // 
            txtSegundoNumero.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoNumero.Font = new Font("Arial", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoNumero.Location = new Point(169, 56);
            txtSegundoNumero.Name = "txtSegundoNumero";
            txtSegundoNumero.Size = new Size(60, 26);
            txtSegundoNumero.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(272, 51);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(68, 26);
            txtResultado.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 2;
            label3.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(150, 19);
            label2.TabIndex = 1;
            label2.Text = "Segundo Numero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Numero:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbDivisao);
            groupBox2.Controls.Add(rdbSubtracao);
            groupBox2.Controls.Add(rdbMultiplicacao);
            groupBox2.Controls.Add(rdbAdicao);
            groupBox2.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(101, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 181);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Escolha a Opção:";
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(24, 116);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(84, 23);
            rdbDivisao.TabIndex = 5;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(24, 58);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(106, 23);
            rdbSubtracao.TabIndex = 3;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(24, 87);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(127, 23);
            rdbMultiplicacao.TabIndex = 4;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Checked = true;
            rdbAdicao.Location = new Point(24, 29);
            rdbAdicao.Name = "rdbAdicao";
            rdbAdicao.Size = new Size(80, 23);
            rdbAdicao.TabIndex = 2;
            rdbAdicao.TabStop = true;
            rdbAdicao.Text = "Adição";
            rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(101, 316);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(360, 28);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += BotaoCalcular;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(101, 359);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(360, 28);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar Tela:";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += BotaoLimpar;
            // 
            // ListaDeHistorico
            // 
            ListaDeHistorico.BorderStyle = BorderStyle.FixedSingle;
            ListaDeHistorico.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListaDeHistorico.FormattingEnabled = true;
            ListaDeHistorico.Location = new Point(102, 414);
            ListaDeHistorico.Name = "ListaDeHistorico";
            ListaDeHistorico.Size = new Size(360, 116);
            ListaDeHistorico.TabIndex = 8;
            ListaDeHistorico.SelectedIndexChanged += ListaHistorico;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 396);
            label4.Name = "label4";
            label4.Size = new Size(194, 19);
            label4.TabIndex = 8;
            label4.Text = "Histórico de Operações:";
            // 
            // CalculadoraSimples
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(549, 564);
            Controls.Add(label4);
            Controls.Add(ListaDeHistorico);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CalculadoraSimples";
            Text = "ProjetoCalculadoraSimples";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label label3;
        private TextBox txtPrimeiroNumero;
        private TextBox txtSegundoNumero;
        private TextBox txtResultado;
        private RadioButton rdbDivisao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbAdicao;
        private Label label4;
        public ListBox ListaDeHistorico;
    }
}

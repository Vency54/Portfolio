namespace Atividade
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
            label1 = new Label();
            txtProntuario = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCPF = new TextBox();
            txtRG = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            btnIncluir = new Button();
            btnLimpar = new Button();
            Consultar = new Button();
            Alterar = new Button();
            Excluir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Prontuario";
            // 
            // txtProntuario
            // 
            txtProntuario.Location = new Point(168, 61);
            txtProntuario.Name = "txtProntuario";
            txtProntuario.Size = new Size(100, 23);
            txtProntuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 102);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(168, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 154);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 154);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 5;
            label4.Text = "RG";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(128, 151);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 6;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(314, 151);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(100, 23);
            txtRG.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 204);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(72, 294);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 10;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(460, 294);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Consultar
            // 
            Consultar.Location = new Point(168, 294);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(75, 23);
            Consultar.TabIndex = 12;
            Consultar.Text = "Consultar";
            Consultar.UseVisualStyleBackColor = true;
            Consultar.Click += Consultar_Click;
            // 
            // Alterar
            // 
            Alterar.Location = new Point(269, 294);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(75, 23);
            Alterar.TabIndex = 13;
            Alterar.Text = "Alterar";
            Alterar.UseVisualStyleBackColor = true;
            Alterar.Click += Alterar_Click;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(366, 294);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 14;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Excluir);
            Controls.Add(Alterar);
            Controls.Add(Consultar);
            Controls.Add(btnLimpar);
            Controls.Add(btnIncluir);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtRG);
            Controls.Add(txtCPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtProntuario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProntuario;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private TextBox txtCPF;
        private TextBox txtRG;
        private Label label5;
        private TextBox txtEmail;
        private Button btnIncluir;
        private Button btnLimpar;
        private Button Consultar;
        private Button Alterar;
        private Button Excluir;
    }
}

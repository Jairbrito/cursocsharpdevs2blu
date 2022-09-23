namespace Devs2Blu.ProjetosAula.AulaOPP1Int
{
    partial class Form1
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
            this.gbCadastroFuncionario = new System.Windows.Forms.GroupBox();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDiretor = new System.Windows.Forms.RadioButton();
            this.rdRecepcionista = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbCadastroFuncionario.SuspendLayout();
            this.gbControles.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroFuncionario
            // 
            this.gbCadastroFuncionario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbCadastroFuncionario.Controls.Add(this.groupBox1);
            this.gbCadastroFuncionario.Controls.Add(this.lblName);
            this.gbCadastroFuncionario.Controls.Add(this.textBox2);
            this.gbCadastroFuncionario.Controls.Add(this.txtSobrenome);
            this.gbCadastroFuncionario.Controls.Add(this.txtEndereco);
            this.gbCadastroFuncionario.Controls.Add(this.txtNascimento);
            this.gbCadastroFuncionario.Controls.Add(this.txtNome);
            this.gbCadastroFuncionario.Controls.Add(this.label3);
            this.gbCadastroFuncionario.Controls.Add(this.label2);
            this.gbCadastroFuncionario.Controls.Add(this.label1);
            this.gbCadastroFuncionario.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroFuncionario.Name = "gbCadastroFuncionario";
            this.gbCadastroFuncionario.Size = new System.Drawing.Size(308, 426);
            this.gbCadastroFuncionario.TabIndex = 0;
            this.gbCadastroFuncionario.TabStop = false;
            this.gbCadastroFuncionario.Text = "Cadastro de Funcionarios";
            // 
            // gbControles
            // 
            this.gbControles.BackColor = System.Drawing.SystemColors.Menu;
            this.gbControles.Controls.Add(this.btnLimpar);
            this.gbControles.Controls.Add(this.btnSalvar);
            this.gbControles.Location = new System.Drawing.Point(344, 312);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(278, 126);
            this.gbControles.TabIndex = 1;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.gbStatus.Controls.Add(this.txtStatus);
            this.gbStatus.Location = new System.Drawing.Point(344, 13);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(278, 293);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtStatus.Enabled = false;
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Location = new System.Drawing.Point(7, 20);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(265, 267);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "Cadastro Funcionario...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereco: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(70, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(123, 66);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(95, 20);
            this.txtNascimento.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(122, 96);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(180, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(199, 35);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(103, 20);
            this.txtSobrenome.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Location = new System.Drawing.Point(224, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(258, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "anos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRecepcionista);
            this.groupBox1.Controls.Add(this.rdDiretor);
            this.groupBox1.Location = new System.Drawing.Point(31, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Funcionario";
            // 
            // rdDiretor
            // 
            this.rdDiretor.AutoSize = true;
            this.rdDiretor.Checked = true;
            this.rdDiretor.Location = new System.Drawing.Point(29, 51);
            this.rdDiretor.Name = "rdDiretor";
            this.rdDiretor.Size = new System.Drawing.Size(56, 17);
            this.rdDiretor.TabIndex = 0;
            this.rdDiretor.TabStop = true;
            this.rdDiretor.Text = "Diretor";
            this.rdDiretor.UseVisualStyleBackColor = true;
            // 
            // rdRecepcionista
            // 
            this.rdRecepcionista.AutoSize = true;
            this.rdRecepcionista.Checked = true;
            this.rdRecepcionista.Location = new System.Drawing.Point(127, 51);
            this.rdRecepcionista.Name = "rdRecepcionista";
            this.rdRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.rdRecepcionista.TabIndex = 1;
            this.rdRecepcionista.TabStop = true;
            this.rdRecepcionista.Text = "Recepcionista";
            this.rdRecepcionista.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(83, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Location = new System.Drawing.Point(83, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.gbCadastroFuncionario);
            this.Name = "Form1";
            this.Text = "Aula OOP 1 - Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCadastroFuncionario.ResumeLayout(false);
            this.gbCadastroFuncionario.PerformLayout();
            this.gbControles.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroFuncionario;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRecepcionista;
        private System.Windows.Forms.RadioButton rdDiretor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}


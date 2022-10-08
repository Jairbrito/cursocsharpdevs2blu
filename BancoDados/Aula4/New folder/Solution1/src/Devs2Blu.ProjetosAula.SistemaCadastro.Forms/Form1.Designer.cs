namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
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
            this.gpPoliCadastro = new System.Windows.Forms.GroupBox();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelControles = new System.Windows.Forms.Panel();
            this.gpConteudo = new System.Windows.Forms.GroupBox();
            this.btnINFO = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.gpPoliCadastro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.gpConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPoliCadastro
            // 
            this.gpPoliCadastro.BackColor = System.Drawing.SystemColors.Menu;
            this.gpPoliCadastro.Controls.Add(this.txtCpf);
            this.gpPoliCadastro.Controls.Add(this.btnLimpar);
            this.gpPoliCadastro.Controls.Add(this.groupBox3);
            this.gpPoliCadastro.Controls.Add(this.groupBox2);
            this.gpPoliCadastro.Controls.Add(this.txtNome);
            this.gpPoliCadastro.Controls.Add(this.lblCGCCPF);
            this.gpPoliCadastro.Controls.Add(this.label2);
            this.gpPoliCadastro.Controls.Add(this.label1);
            this.gpPoliCadastro.Controls.Add(this.cboConvenio);
            this.gpPoliCadastro.Location = new System.Drawing.Point(13, 27);
            this.gpPoliCadastro.Name = "gpPoliCadastro";
            this.gpPoliCadastro.Size = new System.Drawing.Size(386, 309);
            this.gpPoliCadastro.TabIndex = 2;
            this.gpPoliCadastro.TabStop = false;
            this.gpPoliCadastro.Text = "Cadastro Form";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(31, 76);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCGCCPF.TabIndex = 9;
            this.lblCGCCPF.Text = "CPF";
            this.lblCGCCPF.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo pessoa";
            this.groupBox2.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Juridica";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(126, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fisica";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convenio";
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(64, 24);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(272, 21);
            this.cboConvenio.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.mskCEP);
            this.groupBox3.Controls.Add(this.cboUF);
            this.groupBox3.Controls.Add(this.txtNUM);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.txtRua);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereco/Contato";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(271, 20);
            this.txtNome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "UF";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(56, 38);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(193, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(270, 13);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(92, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(56, 66);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(193, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(304, 38);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(57, 20);
            this.txtNUM.TabIndex = 12;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(172, 13);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(48, 21);
            this.cboUF.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(6, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 74);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(26, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.btnExcluir);
            this.panelControles.Controls.Add(this.btnSalvar);
            this.panelControles.Controls.Add(this.btnINFO);
            this.panelControles.Location = new System.Drawing.Point(13, 351);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(775, 87);
            this.panelControles.TabIndex = 3;
            // 
            // gpConteudo
            // 
            this.gpConteudo.Controls.Add(this.gridPaciente);
            this.gpConteudo.Location = new System.Drawing.Point(405, 27);
            this.gpConteudo.Name = "gpConteudo";
            this.gpConteudo.Size = new System.Drawing.Size(383, 317);
            this.gpConteudo.TabIndex = 4;
            this.gpConteudo.TabStop = false;
            // 
            // btnINFO
            // 
            this.btnINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINFO.Location = new System.Drawing.Point(589, 3);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(113, 74);
            this.btnINFO.TabIndex = 0;
            this.btnINFO.Text = "INFO";
            this.btnINFO.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(178, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 74);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gridPaciente
            // 
            this.gridPaciente.AllowUserToAddRows = false;
            this.gridPaciente.AllowUserToOrderColumns = true;
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Location = new System.Drawing.Point(6, 19);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.ReadOnly = true;
            this.gridPaciente.Size = new System.Drawing.Size(371, 290);
            this.gridPaciente.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(64, 73);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(271, 20);
            this.txtCpf.TabIndex = 14;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(56, 13);
            this.mskCEP.Mask = "___.___-__";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(83, 20);
            this.mskCEP.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpConteudo);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.gpPoliCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpPoliCadastro.ResumeLayout(false);
            this.gpPoliCadastro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.gpConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPoliCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtNUM;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnINFO;
        private System.Windows.Forms.GroupBox gpConteudo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox mskCEP;
    }
}


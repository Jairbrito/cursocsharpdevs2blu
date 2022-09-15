namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    partial class TelaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(582, 437);
            this.Controls.Add(this.button1);
            this.Name = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.GroupBox gbCPU;
        private System.Windows.Forms.Button btnJogarPlayer;
        private System.Windows.Forms.TextBox tbP3;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.TextBox tbCPU3;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResultPlayer;
        private System.Windows.Forms.TextBox txtResultCPU;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button1;
    }
}


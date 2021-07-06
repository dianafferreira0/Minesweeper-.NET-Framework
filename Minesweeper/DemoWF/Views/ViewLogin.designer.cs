namespace DemoWF.Views
{
    partial class ViewLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJogador = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.buttonMenuEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(195, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efetuar Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(194, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label3.Location = new System.Drawing.Point(180, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // textBoxJogador
            // 
            this.textBoxJogador.Location = new System.Drawing.Point(290, 169);
            this.textBoxJogador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxJogador.Name = "textBoxJogador";
            this.textBoxJogador.Size = new System.Drawing.Size(228, 26);
            this.textBoxJogador.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(290, 211);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(228, 26);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonLogin.Location = new System.Drawing.Point(16, 337);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(134, 46);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRegistar.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonRegistar.Location = new System.Drawing.Point(158, 337);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(182, 46);
            this.buttonRegistar.TabIndex = 7;
            this.buttonRegistar.Text = "Fazer registo";
            this.buttonRegistar.UseVisualStyleBackColor = false;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // buttonMenuEL
            // 
            this.buttonMenuEL.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuEL.BackgroundImage = global::DemoWF.Properties.Resources.Seta;
            this.buttonMenuEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuEL.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMenuEL.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuEL.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuEL.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuEL.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuEL.Name = "buttonMenuEL";
            this.buttonMenuEL.Size = new System.Drawing.Size(53, 37);
            this.buttonMenuEL.TabIndex = 10;
            this.buttonMenuEL.UseVisualStyleBackColor = false;
            this.buttonMenuEL.Click += new System.EventHandler(this.buttonMenuEL_Click);
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonMenuEL);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.ViewLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJogador;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.Button buttonMenuEL;
    }
}
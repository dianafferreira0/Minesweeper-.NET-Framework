namespace DemoWF.Views
{
    partial class ViewSecundario
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonJogar2 = new System.Windows.Forms.Button();
            this.buttonTop10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonLogout.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(310, 258);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(134, 43);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.BackColor = System.Drawing.Color.Black;
            this.buttonPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPerfil.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonPerfil.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfil.ForeColor = System.Drawing.Color.White;
            this.buttonPerfil.Location = new System.Drawing.Point(310, 208);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(134, 43);
            this.buttonPerfil.TabIndex = 8;
            this.buttonPerfil.Text = "Perfil";
            this.buttonPerfil.UseVisualStyleBackColor = false;
            this.buttonPerfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonJogar2
            // 
            this.buttonJogar2.BackColor = System.Drawing.Color.Black;
            this.buttonJogar2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogar2.ForeColor = System.Drawing.Color.White;
            this.buttonJogar2.Location = new System.Drawing.Point(310, 112);
            this.buttonJogar2.Name = "buttonJogar2";
            this.buttonJogar2.Size = new System.Drawing.Size(134, 43);
            this.buttonJogar2.TabIndex = 9;
            this.buttonJogar2.Text = "Jogar";
            this.buttonJogar2.UseVisualStyleBackColor = false;
            this.buttonJogar2.Click += new System.EventHandler(this.buttonJogar2_Click);
            // 
            // buttonTop10
            // 
            this.buttonTop10.BackColor = System.Drawing.Color.Black;
            this.buttonTop10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTop10.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTop10.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonTop10.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTop10.ForeColor = System.Drawing.Color.White;
            this.buttonTop10.Location = new System.Drawing.Point(310, 161);
            this.buttonTop10.Name = "buttonTop10";
            this.buttonTop10.Size = new System.Drawing.Size(134, 43);
            this.buttonTop10.TabIndex = 10;
            this.buttonTop10.Text = "Top10";
            this.buttonTop10.UseVisualStyleBackColor = false;
            this.buttonTop10.Click += new System.EventHandler(this.buttonTop10_Click);
            // 
            // ViewSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DemoWF.Properties.Resources.Sem_Título41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonTop10);
            this.Controls.Add(this.buttonJogar2);
            this.Controls.Add(this.buttonPerfil);
            this.Controls.Add(this.buttonLogout);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewSecundario";
            this.Text = "Menu do jogador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button buttonJogar2;
        private System.Windows.Forms.Button buttonTop10;
    }
}
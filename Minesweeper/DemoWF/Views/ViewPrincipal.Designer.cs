namespace DemoWF.Views
{
    partial class ViewPrincipal
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegras = new System.Windows.Forms.Button();
            this.buttonCreditos = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonModoJogo = new System.Windows.Forms.Button();
            this.buttonTop1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonLogin.Location = new System.Drawing.Point(309, 132);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Modo Online";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegras
            // 
            this.buttonRegras.BackColor = System.Drawing.Color.Black;
            this.buttonRegras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegras.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegras.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonRegras.Location = new System.Drawing.Point(309, 225);
            this.buttonRegras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegras.Name = "buttonRegras";
            this.buttonRegras.Size = new System.Drawing.Size(180, 48);
            this.buttonRegras.TabIndex = 1;
            this.buttonRegras.Text = "Regras";
            this.buttonRegras.UseVisualStyleBackColor = false;
            this.buttonRegras.Click += new System.EventHandler(this.buttonRegras_Click);
            // 
            // buttonCreditos
            // 
            this.buttonCreditos.BackColor = System.Drawing.Color.Black;
            this.buttonCreditos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreditos.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreditos.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonCreditos.Location = new System.Drawing.Point(309, 272);
            this.buttonCreditos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreditos.Name = "buttonCreditos";
            this.buttonCreditos.Size = new System.Drawing.Size(180, 48);
            this.buttonCreditos.TabIndex = 2;
            this.buttonCreditos.Text = "Créditos";
            this.buttonCreditos.UseVisualStyleBackColor = false;
            this.buttonCreditos.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.BackgroundImage = global::DemoWF.Properties.Resources.exit;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonSair.Location = new System.Drawing.Point(652, 21);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(42, 43);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // buttonModoJogo
            // 
            this.buttonModoJogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModoJogo.BackColor = System.Drawing.Color.Black;
            this.buttonModoJogo.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModoJogo.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonModoJogo.Location = new System.Drawing.Point(309, 80);
            this.buttonModoJogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModoJogo.Name = "buttonModoJogo";
            this.buttonModoJogo.Size = new System.Drawing.Size(180, 53);
            this.buttonModoJogo.TabIndex = 4;
            this.buttonModoJogo.Text = "Modo Offline";
            this.buttonModoJogo.UseVisualStyleBackColor = false;
            this.buttonModoJogo.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // buttonTop1
            // 
            this.buttonTop1.BackColor = System.Drawing.Color.Black;
            this.buttonTop1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTop1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTop1.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonTop1.Location = new System.Drawing.Point(309, 179);
            this.buttonTop1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTop1.Name = "buttonTop1";
            this.buttonTop1.Size = new System.Drawing.Size(180, 48);
            this.buttonTop1.TabIndex = 7;
            this.buttonTop1.Text = "Top1";
            this.buttonTop1.UseVisualStyleBackColor = false;
            this.buttonTop1.Click += new System.EventHandler(this.buttonTop1_Click);
            // 
            // ViewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DemoWF.Properties.Resources.Sem_Título4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonTop1);
            this.Controls.Add(this.buttonModoJogo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonCreditos);
            this.Controls.Add(this.buttonRegras);
            this.Controls.Add(this.buttonLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegras;
        private System.Windows.Forms.Button buttonCreditos;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonModoJogo;
        private System.Windows.Forms.Button buttonTop1;
    }
}
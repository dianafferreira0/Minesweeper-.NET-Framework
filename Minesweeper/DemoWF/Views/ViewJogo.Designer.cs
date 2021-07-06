namespace DemoWF.Views
{
    partial class ViewJogo
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
            this.components = new System.ComponentModel.Container();
            this.menuStripNovoJogo = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TempoDeJogo = new System.Windows.Forms.Timer(this.components);
            this.labelDuracao = new System.Windows.Forms.Label();
            this.labelMinas = new System.Windows.Forms.Label();
            this.menuOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBandeira = new System.Windows.Forms.Button();
            this.buttonSmile = new System.Windows.Forms.Button();
            this.menuStripNovoJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripNovoJogo
            // 
            this.menuStripNovoJogo.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStripNovoJogo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripNovoJogo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripNovoJogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStripNovoJogo.Location = new System.Drawing.Point(0, 0);
            this.menuStripNovoJogo.Name = "menuStripNovoJogo";
            this.menuStripNovoJogo.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStripNovoJogo.Size = new System.Drawing.Size(454, 36);
            this.menuStripNovoJogo.TabIndex = 0;
            this.menuStripNovoJogo.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.menuOfflineToolStripMenuItem,
            this.menuOnlineToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.newGameToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(270, 36);
            this.newGameToolStripMenuItem1.Text = "Novo Jogo";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TempoDeJogo
            // 
            this.TempoDeJogo.Interval = 1000;
            this.TempoDeJogo.Tick += new System.EventHandler(this.TempoDeJogo_Tick);
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracao.Location = new System.Drawing.Point(14, 54);
            this.labelDuracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(82, 24);
            this.labelDuracao.TabIndex = 1;
            this.labelDuracao.Text = "Duração:";
            // 
            // labelMinas
            // 
            this.labelMinas.AutoSize = true;
            this.labelMinas.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinas.Location = new System.Drawing.Point(134, 54);
            this.labelMinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinas.Name = "labelMinas";
            this.labelMinas.Size = new System.Drawing.Size(69, 24);
            this.labelMinas.TabIndex = 2;
            this.labelMinas.Text = "Minas: ";
            // 
            // menuOfflineToolStripMenuItem
            // 
            this.menuOfflineToolStripMenuItem.Name = "menuOfflineToolStripMenuItem";
            this.menuOfflineToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.menuOfflineToolStripMenuItem.Text = "Menu Offline";
            this.menuOfflineToolStripMenuItem.Click += new System.EventHandler(this.menuOfflineToolStripMenuItem_Click_1);
            // 
            // menuOnlineToolStripMenuItem
            // 
            this.menuOnlineToolStripMenuItem.Name = "menuOnlineToolStripMenuItem";
            this.menuOnlineToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.menuOnlineToolStripMenuItem.Text = "Menu Online";
            this.menuOnlineToolStripMenuItem.Click += new System.EventHandler(this.menuOnlineToolStripMenuItem_Click);
            // 
            // buttonBandeira
            // 
            this.buttonBandeira.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonBandeira.BackgroundImage = global::DemoWF.Properties.Resources.Bandeira;
            this.buttonBandeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBandeira.Location = new System.Drawing.Point(388, 14);
            this.buttonBandeira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBandeira.Name = "buttonBandeira";
            this.buttonBandeira.Size = new System.Drawing.Size(52, 49);
            this.buttonBandeira.TabIndex = 4;
            this.buttonBandeira.UseVisualStyleBackColor = false;
            this.buttonBandeira.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSmile
            // 
            this.buttonSmile.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSmile.BackgroundImage = global::DemoWF.Properties.Resources.Feliz4;
            this.buttonSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSmile.Location = new System.Drawing.Point(330, 14);
            this.buttonSmile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSmile.Name = "buttonSmile";
            this.buttonSmile.Size = new System.Drawing.Size(51, 49);
            this.buttonSmile.TabIndex = 3;
            this.buttonSmile.UseVisualStyleBackColor = false;
            this.buttonSmile.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(454, 428);
            this.Controls.Add(this.buttonBandeira);
            this.Controls.Add(this.buttonSmile);
            this.Controls.Add(this.labelMinas);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.menuStripNovoJogo);
            this.MainMenuStrip = this.menuStripNovoJogo;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewJogo";
            this.Text = "Minesweeper";
            this.menuStripNovoJogo.ResumeLayout(false);
            this.menuStripNovoJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNovoJogo;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.Timer TempoDeJogo;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.Label labelMinas;
        private System.Windows.Forms.Button buttonSmile;
        private System.Windows.Forms.Button buttonBandeira;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOfflineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOnlineToolStripMenuItem;
    }
}
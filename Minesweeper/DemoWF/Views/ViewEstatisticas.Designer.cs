namespace DemoWF.Views
{
    partial class ViewEstatisticas
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.listBoxEstatisticas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxEstatisticas = new System.Windows.Forms.GroupBox();
            this.buttonMenuES = new System.Windows.Forms.Button();
            this.groupBoxEstatisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 10";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonSair.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonSair.Location = new System.Drawing.Point(330, 339);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(134, 43);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listBoxEstatisticas
            // 
            this.listBoxEstatisticas.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEstatisticas.FormattingEnabled = true;
            this.listBoxEstatisticas.HorizontalScrollbar = true;
            this.listBoxEstatisticas.ItemHeight = 24;
            this.listBoxEstatisticas.Location = new System.Drawing.Point(33, 49);
            this.listBoxEstatisticas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEstatisticas.Name = "listBoxEstatisticas";
            this.listBoxEstatisticas.ScrollAlwaysVisible = true;
            this.listBoxEstatisticas.Size = new System.Drawing.Size(604, 172);
            this.listBoxEstatisticas.TabIndex = 9;
            this.listBoxEstatisticas.SelectedIndexChanged += new System.EventHandler(this.listBoxEstatisticas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Melhores Tempos:";
            // 
            // groupBoxEstatisticas
            // 
            this.groupBoxEstatisticas.Controls.Add(this.label2);
            this.groupBoxEstatisticas.Controls.Add(this.listBoxEstatisticas);
            this.groupBoxEstatisticas.Location = new System.Drawing.Point(45, 85);
            this.groupBoxEstatisticas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstatisticas.Name = "groupBoxEstatisticas";
            this.groupBoxEstatisticas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstatisticas.Size = new System.Drawing.Size(674, 246);
            this.groupBoxEstatisticas.TabIndex = 11;
            this.groupBoxEstatisticas.TabStop = false;
            // 
            // buttonMenuES
            // 
            this.buttonMenuES.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuES.BackgroundImage = global::DemoWF.Properties.Resources.Seta;
            this.buttonMenuES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuES.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMenuES.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuES.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuES.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuES.Location = new System.Drawing.Point(12, 9);
            this.buttonMenuES.Name = "buttonMenuES";
            this.buttonMenuES.Size = new System.Drawing.Size(53, 37);
            this.buttonMenuES.TabIndex = 14;
            this.buttonMenuES.UseVisualStyleBackColor = false;
            this.buttonMenuES.Click += new System.EventHandler(this.buttonMenuES_Click_1);
            // 
            // ViewEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonMenuES);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBoxEstatisticas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewEstatisticas";
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.ViewEstatisticas_Load);
            this.groupBoxEstatisticas.ResumeLayout(false);
            this.groupBoxEstatisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListBox listBoxEstatisticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxEstatisticas;
        private System.Windows.Forms.Button buttonMenuES;
    }
}
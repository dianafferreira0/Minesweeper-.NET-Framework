namespace DemoWF.Views
{
    partial class ViewRegras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRegras));
            this.textBoxRegras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenuR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRegras
            // 
            this.textBoxRegras.Location = new System.Drawing.Point(91, 93);
            this.textBoxRegras.Multiline = true;
            this.textBoxRegras.Name = "textBoxRegras";
            this.textBoxRegras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegras.Size = new System.Drawing.Size(578, 292);
            this.textBoxRegras.TabIndex = 2;
            this.textBoxRegras.Text = resources.GetString("textBoxRegras.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regras";
            // 
            // buttonMenuR
            // 
            this.buttonMenuR.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuR.BackgroundImage = global::DemoWF.Properties.Resources.Seta;
            this.buttonMenuR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMenuR.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuR.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuR.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuR.Location = new System.Drawing.Point(12, 9);
            this.buttonMenuR.Name = "buttonMenuR";
            this.buttonMenuR.Size = new System.Drawing.Size(53, 37);
            this.buttonMenuR.TabIndex = 9;
            this.buttonMenuR.UseVisualStyleBackColor = false;
            this.buttonMenuR.Click += new System.EventHandler(this.buttonMenuR_Click);
            // 
            // ViewRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonMenuR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegras);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewRegras";
            this.Text = "Regras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRegras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuR;
    }
}
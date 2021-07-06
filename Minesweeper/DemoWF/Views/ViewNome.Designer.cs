namespace DemoWF.Views
{
    partial class ViewNome
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFinalNome = new System.Windows.Forms.TextBox();
            this.buttonOKNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Primeiro nome";
            // 
            // textBoxFinalNome
            // 
            this.textBoxFinalNome.Location = new System.Drawing.Point(18, 42);
            this.textBoxFinalNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFinalNome.Name = "textBoxFinalNome";
            this.textBoxFinalNome.Size = new System.Drawing.Size(193, 20);
            this.textBoxFinalNome.TabIndex = 12;
            // 
            // buttonOKNome
            // 
            this.buttonOKNome.BackgroundImage = global::DemoWF.Properties.Resources.ok;
            this.buttonOKNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOKNome.Location = new System.Drawing.Point(103, 62);
            this.buttonOKNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOKNome.Name = "buttonOKNome";
            this.buttonOKNome.Size = new System.Drawing.Size(27, 25);
            this.buttonOKNome.TabIndex = 13;
            this.buttonOKNome.UseVisualStyleBackColor = true;
            this.buttonOKNome.Click += new System.EventHandler(this.buttonOKNome_Click);
            // 
            // ViewNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(229, 106);
            this.Controls.Add(this.buttonOKNome);
            this.Controls.Add(this.textBoxFinalNome);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewNome";
            this.Text = "ViewNome";
            this.Load += new System.EventHandler(this.ViewNome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFinalNome;
        private System.Windows.Forms.Button buttonOKNome;
    }
}
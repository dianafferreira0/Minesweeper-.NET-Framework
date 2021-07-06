namespace DemoWF.Views
{
    partial class ViewDificuldade
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
            this.groupBoxDificuldade = new System.Windows.Forms.GroupBox();
            this.buttonFacil = new System.Windows.Forms.Button();
            this.buttonMedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDificuldade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(226, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dificuldade";
            // 
            // groupBoxDificuldade
            // 
            this.groupBoxDificuldade.Controls.Add(this.buttonFacil);
            this.groupBoxDificuldade.Controls.Add(this.buttonMedio);
            this.groupBoxDificuldade.Location = new System.Drawing.Point(237, 168);
            this.groupBoxDificuldade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDificuldade.Name = "groupBoxDificuldade";
            this.groupBoxDificuldade.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDificuldade.Size = new System.Drawing.Size(299, 125);
            this.groupBoxDificuldade.TabIndex = 7;
            this.groupBoxDificuldade.TabStop = false;
            // 
            // buttonFacil
            // 
            this.buttonFacil.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFacil.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacil.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonFacil.Location = new System.Drawing.Point(26, 38);
            this.buttonFacil.Name = "buttonFacil";
            this.buttonFacil.Size = new System.Drawing.Size(113, 54);
            this.buttonFacil.TabIndex = 11;
            this.buttonFacil.Text = "Fácil";
            this.buttonFacil.UseVisualStyleBackColor = false;
            this.buttonFacil.Click += new System.EventHandler(this.buttonFacil_Click);
            // 
            // buttonMedio
            // 
            this.buttonMedio.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMedio.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedio.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMedio.Location = new System.Drawing.Point(159, 38);
            this.buttonMedio.Name = "buttonMedio";
            this.buttonMedio.Size = new System.Drawing.Size(115, 54);
            this.buttonMedio.TabIndex = 12;
            this.buttonMedio.Text = "Médio";
            this.buttonMedio.UseVisualStyleBackColor = false;
            this.buttonMedio.Click += new System.EventHandler(this.buttonMedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecione a dificuldade:";
            // 
            // ViewDificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxDificuldade);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewDificuldade";
            this.Text = "Dificuldade";
            this.groupBoxDificuldade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDificuldade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFacil;
        private System.Windows.Forms.Button buttonMedio;
    }
}
        

namespace DemoWF.Views
{
    partial class ViewTop1
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
            this.labelMelhoresTemp = new System.Windows.Forms.Label();
            this.groupBoxTop1 = new System.Windows.Forms.GroupBox();
            this.buttonMenuTop1 = new System.Windows.Forms.Button();
            this.textBoxTempos = new System.Windows.Forms.TextBox();
            this.groupBoxTop1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 1";
            // 
            // labelMelhoresTemp
            // 
            this.labelMelhoresTemp.AutoSize = true;
            this.labelMelhoresTemp.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMelhoresTemp.Location = new System.Drawing.Point(27, 15);
            this.labelMelhoresTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMelhoresTemp.Name = "labelMelhoresTemp";
            this.labelMelhoresTemp.Size = new System.Drawing.Size(177, 27);
            this.labelMelhoresTemp.TabIndex = 10;
            this.labelMelhoresTemp.Text = "Melhores Tempos:";
            // 
            // groupBoxTop1
            // 
            this.groupBoxTop1.Controls.Add(this.textBoxTempos);
            this.groupBoxTop1.Controls.Add(this.labelMelhoresTemp);
            this.groupBoxTop1.Location = new System.Drawing.Point(45, 85);
            this.groupBoxTop1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTop1.Name = "groupBoxTop1";
            this.groupBoxTop1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTop1.Size = new System.Drawing.Size(674, 246);
            this.groupBoxTop1.TabIndex = 11;
            this.groupBoxTop1.TabStop = false;
            // 
            // buttonMenuTop1
            // 
            this.buttonMenuTop1.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuTop1.BackgroundImage = global::DemoWF.Properties.Resources.Seta;
            this.buttonMenuTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuTop1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMenuTop1.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuTop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuTop1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuTop1.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMenuTop1.Location = new System.Drawing.Point(12, 9);
            this.buttonMenuTop1.Name = "buttonMenuTop1";
            this.buttonMenuTop1.Size = new System.Drawing.Size(53, 37);
            this.buttonMenuTop1.TabIndex = 14;
            this.buttonMenuTop1.UseVisualStyleBackColor = false;
            this.buttonMenuTop1.Click += new System.EventHandler(this.buttonMenuTop1_Click);
            // 
            // textBoxTempos
            // 
            this.textBoxTempos.Location = new System.Drawing.Point(32, 46);
            this.textBoxTempos.Multiline = true;
            this.textBoxTempos.Name = "textBoxTempos";
            this.textBoxTempos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTempos.Size = new System.Drawing.Size(621, 174);
            this.textBoxTempos.TabIndex = 11;
            // 
            // ViewTop1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.buttonMenuTop1);
            this.Controls.Add(this.groupBoxTop1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewTop1";
            this.Text = "Top1";
            this.groupBoxTop1.ResumeLayout(false);
            this.groupBoxTop1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMelhoresTemp;
        private System.Windows.Forms.GroupBox groupBoxTop1;
        private System.Windows.Forms.Button buttonMenuTop1;
        private System.Windows.Forms.TextBox textBoxTempos;
    }
}
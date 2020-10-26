namespace BIM_Calculator
{
    partial class Form1
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
            this.txtLengte = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.TextBox();
            this.lblGewicht = new System.Windows.Forms.TextBox();
            this.lblLeeftijd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.TextBox();
            this.lblAdvies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BMI Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLengte
            // 
            this.txtLengte.AutoSize = true;
            this.txtLengte.Location = new System.Drawing.Point(58, 106);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(65, 13);
            this.txtLengte.TabIndex = 4;
            this.txtLengte.Text = "Lengte in m:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.AutoSize = true;
            this.txtGewicht.Location = new System.Drawing.Point(58, 148);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(75, 13);
            this.txtGewicht.TabIndex = 5;
            this.txtGewicht.Text = "Gewicht in kg:";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.AutoSize = true;
            this.txtLeeftijd.Location = new System.Drawing.Point(58, 192);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(44, 13);
            this.txtLeeftijd.TabIndex = 6;
            this.txtLeeftijd.Text = "Leeftijd:";
            // 
            // lblLengte
            // 
            this.lblLengte.Location = new System.Drawing.Point(143, 99);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(109, 20);
            this.lblLengte.TabIndex = 7;
            // 
            // lblGewicht
            // 
            this.lblGewicht.Location = new System.Drawing.Point(143, 141);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(109, 20);
            this.lblGewicht.TabIndex = 8;
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.Location = new System.Drawing.Point(143, 185);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(109, 20);
            this.lblLeeftijd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BMI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Advies";
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(90, 256);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(193, 59);
            this.btnBerekenen.TabIndex = 14;
            this.btnBerekenen.Text = "BMI Berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.Location = new System.Drawing.Point(143, 374);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(109, 20);
            this.lblBMI.TabIndex = 15;
            // 
            // lblAdvies
            // 
            this.lblAdvies.Location = new System.Drawing.Point(115, 422);
            this.lblAdvies.Name = "lblAdvies";
            this.lblAdvies.Size = new System.Drawing.Size(212, 20);
            this.lblAdvies.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 515);
            this.Controls.Add(this.lblAdvies);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLengte;
        private System.Windows.Forms.Label txtGewicht;
        private System.Windows.Forms.Label txtLeeftijd;
        private System.Windows.Forms.TextBox lblLengte;
        private System.Windows.Forms.TextBox lblGewicht;
        private System.Windows.Forms.TextBox lblLeeftijd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.TextBox lblBMI;
        private System.Windows.Forms.TextBox lblAdvies;
    }
}


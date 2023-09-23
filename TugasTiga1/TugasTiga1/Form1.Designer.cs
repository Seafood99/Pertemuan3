namespace TugasTiga1
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
            this.lblNIM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNAMA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKELAS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM       :";
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(185, 54);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(69, 16);
            this.lblNIM.TabIndex = 1;
            this.lblNIM.Text = "22.61.0239";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA   :";
            // 
            // lblNAMA
            // 
            this.lblNAMA.AutoSize = true;
            this.lblNAMA.Location = new System.Drawing.Point(185, 111);
            this.lblNAMA.Name = "lblNAMA";
            this.lblNAMA.Size = new System.Drawing.Size(90, 16);
            this.lblNAMA.TabIndex = 3;
            this.lblNAMA.Text = "Dawam Amali";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KELAS   :";
            // 
            // lblKELAS
            // 
            this.lblKELAS.AutoSize = true;
            this.lblKELAS.Location = new System.Drawing.Point(185, 165);
            this.lblKELAS.Name = "lblKELAS";
            this.lblKELAS.Size = new System.Drawing.Size(62, 16);
            this.lblKELAS.TabIndex = 5;
            this.lblKELAS.Text = "01 BCI 22";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kosongkan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKELAS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNAMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TugasTiga1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNAMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKELAS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


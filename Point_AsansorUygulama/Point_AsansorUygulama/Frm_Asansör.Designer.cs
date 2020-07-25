namespace Point_AsansorUygulama
{
    partial class Frm_Asansör
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asansör));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYukarı = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKat = new System.Windows.Forms.Label();
            this.btnAsansor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 479);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 479);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 42);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(176, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 89);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(536, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 89);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(536, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 89);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(177, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 89);
            this.label7.TabIndex = 6;
            // 
            // btnYukarı
            // 
            this.btnYukarı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYukarı.Image = ((System.Drawing.Image)(resources.GetObject("btnYukarı.Image")));
            this.btnYukarı.Location = new System.Drawing.Point(668, 262);
            this.btnYukarı.Name = "btnYukarı";
            this.btnYukarı.Size = new System.Drawing.Size(90, 81);
            this.btnYukarı.TabIndex = 7;
            this.btnYukarı.UseVisualStyleBackColor = true;
            this.btnYukarı.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsagi.Image = ((System.Drawing.Image)(resources.GetObject("btnAsagi.Image")));
            this.btnAsagi.Location = new System.Drawing.Point(668, 349);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(90, 81);
            this.btnAsagi.TabIndex = 8;
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Location = new System.Drawing.Point(707, 437);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(23, 25);
            this.lblKat.TabIndex = 9;
            this.lblKat.Text = "0";
            // 
            // btnAsansor
            // 
            this.btnAsansor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAsansor.Location = new System.Drawing.Point(315, 405);
            this.btnAsansor.Name = "btnAsansor";
            this.btnAsansor.Size = new System.Drawing.Size(196, 89);
            this.btnAsansor.TabIndex = 10;
            this.btnAsansor.Text = "Asansör";
            this.btnAsansor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Asansör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.btnAsansor);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukarı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Asansör";
            this.Text = "Frm_Asansör";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYukarı;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label btnAsansor;
    }
}
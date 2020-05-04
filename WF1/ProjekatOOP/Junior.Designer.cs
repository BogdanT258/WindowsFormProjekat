namespace ProjekatOOP
{
    partial class Junior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Junior));
            this.fname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ranklabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ageinfo = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workexp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radufirmi = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workexp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radufirmi)).BeginInit();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fname.Location = new System.Drawing.Point(142, 48);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(53, 20);
            this.fname.TabIndex = 0;
            this.fname.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ranklabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ageinfo);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // ranklabel
            // 
            this.ranklabel.AutoSize = true;
            this.ranklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ranklabel.Location = new System.Drawing.Point(233, 111);
            this.ranklabel.Name = "ranklabel";
            this.ranklabel.Size = new System.Drawing.Size(53, 20);
            this.ranklabel.TabIndex = 4;
            this.ranklabel.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ageinfo
            // 
            this.ageinfo.AutoSize = true;
            this.ageinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageinfo.Location = new System.Drawing.Point(142, 111);
            this.ageinfo.Name = "ageinfo";
            this.ageinfo.Size = new System.Drawing.Size(53, 20);
            this.ageinfo.TabIndex = 2;
            this.ageinfo.Text = "label3";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lname.Location = new System.Drawing.Point(233, 48);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(53, 20);
            this.lname.TabIndex = 1;
            this.lname.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many years of experience do you have?";
            // 
            // workexp
            // 
            this.workexp.Location = new System.Drawing.Point(12, 300);
            this.workexp.Name = "workexp";
            this.workexp.Size = new System.Drawing.Size(122, 22);
            this.workexp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "How long have you been working with us?";
            // 
            // radufirmi
            // 
            this.radufirmi.Location = new System.Drawing.Point(12, 384);
            this.radufirmi.Name = "radufirmi";
            this.radufirmi.Size = new System.Drawing.Size(122, 22);
            this.radufirmi.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(106, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Promotion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(71, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min. 2 years of experience and\r\n 1 years of working in the company";
            // 
            // Junior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radufirmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workexp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Junior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junior";
            this.Load += new System.EventHandler(this.Junior_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workexp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radufirmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ageinfo;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown workexp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown radufirmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ranklabel;
        private System.Windows.Forms.Label label4;
    }
}
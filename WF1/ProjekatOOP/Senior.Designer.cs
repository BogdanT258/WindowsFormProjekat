namespace ProjekatOOP
{
    partial class Senior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Senior));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ranklabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ageinfo = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pr1 = new System.Windows.Forms.CheckBox();
            this.pr2 = new System.Windows.Forms.CheckBox();
            this.pr3 = new System.Windows.Forms.CheckBox();
            this.pr4 = new System.Windows.Forms.CheckBox();
            this.Rpromo = new System.Windows.Forms.Button();
            this.Spromo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.extrahours = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrahours)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ranklabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ageinfo);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 173);
            this.groupBox1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(375, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please choose your corporate rank ➣";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "question1\r\n";
            // 
            // pr1
            // 
            this.pr1.AutoSize = true;
            this.pr1.Location = new System.Drawing.Point(22, 240);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(247, 21);
            this.pr1.TabIndex = 10;
            this.pr1.Text = "Blood Bank Management Software";
            this.pr1.UseVisualStyleBackColor = true;
            // 
            // pr2
            // 
            this.pr2.AutoSize = true;
            this.pr2.Location = new System.Drawing.Point(22, 284);
            this.pr2.Name = "pr2";
            this.pr2.Size = new System.Drawing.Size(200, 21);
            this.pr2.TabIndex = 11;
            this.pr2.Text = "HR Match Making Software";
            this.pr2.UseVisualStyleBackColor = true;
            // 
            // pr3
            // 
            this.pr3.AutoSize = true;
            this.pr3.Location = new System.Drawing.Point(312, 240);
            this.pr3.Name = "pr3";
            this.pr3.Size = new System.Drawing.Size(174, 21);
            this.pr3.TabIndex = 12;
            this.pr3.Text = "Inventory Management";
            this.pr3.UseVisualStyleBackColor = true;
            // 
            // pr4
            // 
            this.pr4.AutoSize = true;
            this.pr4.Location = new System.Drawing.Point(312, 284);
            this.pr4.Name = "pr4";
            this.pr4.Size = new System.Drawing.Size(146, 21);
            this.pr4.TabIndex = 13;
            this.pr4.Text = "Debt Management";
            this.pr4.UseVisualStyleBackColor = true;
            // 
            // Rpromo
            // 
            this.Rpromo.BackColor = System.Drawing.SystemColors.Highlight;
            this.Rpromo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Rpromo.FlatAppearance.BorderSize = 3;
            this.Rpromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rpromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rpromo.ForeColor = System.Drawing.Color.White;
            this.Rpromo.Location = new System.Drawing.Point(50, 435);
            this.Rpromo.Name = "Rpromo";
            this.Rpromo.Size = new System.Drawing.Size(219, 47);
            this.Rpromo.TabIndex = 14;
            this.Rpromo.Text = "Rank Promotion";
            this.Rpromo.UseVisualStyleBackColor = false;
            this.Rpromo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Spromo
            // 
            this.Spromo.BackColor = System.Drawing.SystemColors.Highlight;
            this.Spromo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Spromo.FlatAppearance.BorderSize = 3;
            this.Spromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Spromo.ForeColor = System.Drawing.Color.White;
            this.Spromo.Location = new System.Drawing.Point(394, 435);
            this.Spromo.Name = "Spromo";
            this.Spromo.Size = new System.Drawing.Size(219, 47);
            this.Spromo.TabIndex = 15;
            this.Spromo.Text = "Salary Promotion";
            this.Spromo.UseVisualStyleBackColor = false;
            this.Spromo.Click += new System.EventHandler(this.Spromo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "question2";
            // 
            // extrahours
            // 
            this.extrahours.Location = new System.Drawing.Point(113, 358);
            this.extrahours.Name = "extrahours";
            this.extrahours.Size = new System.Drawing.Size(156, 22);
            this.extrahours.TabIndex = 17;
            // 
            // Senior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 510);
            this.Controls.Add(this.extrahours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Spromo);
            this.Controls.Add(this.Rpromo);
            this.Controls.Add(this.pr4);
            this.Controls.Add(this.pr3);
            this.Controls.Add(this.pr2);
            this.Controls.Add(this.pr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Senior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senior";
            this.Load += new System.EventHandler(this.Senior_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrahours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ranklabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ageinfo;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox pr1;
        private System.Windows.Forms.CheckBox pr2;
        private System.Windows.Forms.CheckBox pr3;
        private System.Windows.Forms.CheckBox pr4;
        private System.Windows.Forms.Button Rpromo;
        private System.Windows.Forms.Button Spromo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown extrahours;
    }
}
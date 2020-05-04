namespace ProjekatOOP
{
    partial class information
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
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f1button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pozBox = new System.Windows.Forms.TextBox();
            this.komp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(113, 89);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(141, 22);
            this.fname.TabIndex = 0;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(113, 121);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(141, 22);
            this.lname.TabIndex = 1;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(113, 159);
            this.age.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // f1button
            // 
            this.f1button.Location = new System.Drawing.Point(108, 266);
            this.f1button.Name = "f1button";
            this.f1button.Size = new System.Drawing.Size(146, 48);
            this.f1button.TabIndex = 6;
            this.f1button.Text = "Submit";
            this.f1button.UseVisualStyleBackColor = true;
            this.f1button.Click += new System.EventHandler(this.F1button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rank";
            // 
            // pozBox
            // 
            this.pozBox.Location = new System.Drawing.Point(113, 199);
            this.pozBox.Name = "pozBox";
            this.pozBox.Size = new System.Drawing.Size(141, 22);
            this.pozBox.TabIndex = 8;
            // 
            // komp
            // 
            this.komp.AutoSize = true;
            this.komp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komp.Location = new System.Drawing.Point(89, 29);
            this.komp.Name = "komp";
            this.komp.Size = new System.Drawing.Size(114, 25);
            this.komp.TabIndex = 9;
            this.komp.Text = "Kompanija";
            // 
            // information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 335);
            this.Controls.Add(this.komp);
            this.Controls.Add(this.pozBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f1button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Name = "information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button f1button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pozBox;
        private System.Windows.Forms.Label komp;
    }
}


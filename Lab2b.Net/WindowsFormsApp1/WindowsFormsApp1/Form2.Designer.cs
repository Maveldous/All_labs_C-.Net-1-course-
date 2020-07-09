namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(68, 54);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(156, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Загрузить данные из файла?";
            // 
            // yesbtn
            // 
            this.yesbtn.Location = new System.Drawing.Point(46, 141);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(75, 23);
            this.yesbtn.TabIndex = 1;
            this.yesbtn.Text = "Да";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.Location = new System.Drawing.Point(183, 141);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(75, 23);
            this.nobtn.TabIndex = 2;
            this.nobtn.Text = "Нет";
            this.nobtn.UseVisualStyleBackColor = true;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 183);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
    }
}
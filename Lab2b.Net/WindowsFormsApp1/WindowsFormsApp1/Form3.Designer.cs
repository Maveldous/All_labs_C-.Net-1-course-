namespace WindowsFormsApp1
{
    partial class Form3
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
            this.nobtn2 = new System.Windows.Forms.Button();
            this.yesbtn2 = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nobtn2
            // 
            this.nobtn2.Location = new System.Drawing.Point(182, 123);
            this.nobtn2.Name = "nobtn2";
            this.nobtn2.Size = new System.Drawing.Size(75, 23);
            this.nobtn2.TabIndex = 5;
            this.nobtn2.Text = "Нет";
            this.nobtn2.UseVisualStyleBackColor = true;
            this.nobtn2.Click += new System.EventHandler(this.nobtn2_Click);
            // 
            // yesbtn2
            // 
            this.yesbtn2.Location = new System.Drawing.Point(45, 123);
            this.yesbtn2.Name = "yesbtn2";
            this.yesbtn2.Size = new System.Drawing.Size(75, 23);
            this.yesbtn2.TabIndex = 4;
            this.yesbtn2.Text = "Да";
            this.yesbtn2.UseVisualStyleBackColor = true;
            this.yesbtn2.Click += new System.EventHandler(this.yesbtn2_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(48, 36);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(203, 13);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "Загрузить введенные данные в файл?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 183);
            this.Controls.Add(this.nobtn2);
            this.Controls.Add(this.yesbtn2);
            this.Controls.Add(this.lbl_2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nobtn2;
        private System.Windows.Forms.Button yesbtn2;
        private System.Windows.Forms.Label lbl_2;
    }
}
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlelbl = new System.Windows.Forms.Label();
            this.titletxtbox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.thirdlbl = new System.Windows.Forms.Label();
            this.thirdtxtbox = new System.Windows.Forms.TextBox();
            this.Secondlbl = new System.Windows.Forms.Label();
            this.secondtxtbox = new System.Windows.Forms.TextBox();
            this.firtslbl = new System.Windows.Forms.Label();
            this.firsttxtbox = new System.Windows.Forms.TextBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.resultbtn = new System.Windows.Forms.Button();
            this.numberbtn = new System.Windows.Forms.Button();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.numberlbl = new System.Windows.Forms.Label();
            this.taskbox = new System.Windows.Forms.ComboBox();
            this.tasklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Location = new System.Drawing.Point(74, 104);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(27, 13);
            this.titlelbl.TabIndex = 26;
            this.titlelbl.Text = "Title";
            // 
            // titletxtbox
            // 
            this.titletxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.titletxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titletxtbox.Enabled = false;
            this.titletxtbox.Location = new System.Drawing.Point(143, 102);
            this.titletxtbox.Name = "titletxtbox";
            this.titletxtbox.Size = new System.Drawing.Size(100, 20);
            this.titletxtbox.TabIndex = 25;
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(287, 50);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // thirdlbl
            // 
            this.thirdlbl.AutoSize = true;
            this.thirdlbl.Location = new System.Drawing.Point(74, 78);
            this.thirdlbl.Name = "thirdlbl";
            this.thirdlbl.Size = new System.Drawing.Size(50, 13);
            this.thirdlbl.TabIndex = 22;
            this.thirdlbl.Text = "Thirdside";
            // 
            // thirdtxtbox
            // 
            this.thirdtxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.thirdtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdtxtbox.Enabled = false;
            this.thirdtxtbox.Location = new System.Drawing.Point(143, 76);
            this.thirdtxtbox.Name = "thirdtxtbox";
            this.thirdtxtbox.Size = new System.Drawing.Size(100, 20);
            this.thirdtxtbox.TabIndex = 21;
            // 
            // Secondlbl
            // 
            this.Secondlbl.AutoSize = true;
            this.Secondlbl.Location = new System.Drawing.Point(74, 52);
            this.Secondlbl.Name = "Secondlbl";
            this.Secondlbl.Size = new System.Drawing.Size(63, 13);
            this.Secondlbl.TabIndex = 20;
            this.Secondlbl.Text = "Secondside";
            // 
            // secondtxtbox
            // 
            this.secondtxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.secondtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondtxtbox.Enabled = false;
            this.secondtxtbox.Location = new System.Drawing.Point(143, 50);
            this.secondtxtbox.Name = "secondtxtbox";
            this.secondtxtbox.Size = new System.Drawing.Size(100, 20);
            this.secondtxtbox.TabIndex = 19;
            // 
            // firtslbl
            // 
            this.firtslbl.AutoSize = true;
            this.firtslbl.Location = new System.Drawing.Point(74, 26);
            this.firtslbl.Name = "firtslbl";
            this.firtslbl.Size = new System.Drawing.Size(45, 13);
            this.firtslbl.TabIndex = 18;
            this.firtslbl.Text = "Firstside";
            // 
            // firsttxtbox
            // 
            this.firsttxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.firsttxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firsttxtbox.Enabled = false;
            this.firsttxtbox.Location = new System.Drawing.Point(143, 24);
            this.firsttxtbox.Name = "firsttxtbox";
            this.firsttxtbox.Size = new System.Drawing.Size(100, 20);
            this.firsttxtbox.TabIndex = 17;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(703, 293);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 27;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // resultbtn
            // 
            this.resultbtn.Enabled = false;
            this.resultbtn.Location = new System.Drawing.Point(287, 79);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(75, 23);
            this.resultbtn.TabIndex = 28;
            this.resultbtn.Text = "Show result";
            this.resultbtn.UseVisualStyleBackColor = true;
            this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
            // 
            // numberbtn
            // 
            this.numberbtn.Enabled = false;
            this.numberbtn.Location = new System.Drawing.Point(692, 186);
            this.numberbtn.Name = "numberbtn";
            this.numberbtn.Size = new System.Drawing.Size(75, 23);
            this.numberbtn.TabIndex = 29;
            this.numberbtn.Text = "init";
            this.numberbtn.UseVisualStyleBackColor = true;
            this.numberbtn.Click += new System.EventHandler(this.numberbtn_Click);
            // 
            // numberbox
            // 
            this.numberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberbox.Enabled = false;
            this.numberbox.Location = new System.Drawing.Point(586, 188);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(100, 20);
            this.numberbox.TabIndex = 30;
            // 
            // resultbox
            // 
            this.resultbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultbox.Enabled = false;
            this.resultbox.Location = new System.Drawing.Point(77, 188);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(251, 128);
            this.resultbox.TabIndex = 31;
            // 
            // numberlbl
            // 
            this.numberlbl.AutoSize = true;
            this.numberlbl.Location = new System.Drawing.Point(482, 190);
            this.numberlbl.Name = "numberlbl";
            this.numberlbl.Size = new System.Drawing.Size(98, 13);
            this.numberlbl.TabIndex = 32;
            this.numberlbl.Text = "Number of triangles";
            // 
            // taskbox
            // 
            this.taskbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Task1(regular triangles)",
            "Task2(right triangles)"});
            this.taskbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskbox.FormattingEnabled = true;
            this.taskbox.Items.AddRange(new object[] {
            "Task1(regular triangles)",
            "Task2(right triangles)"});
            this.taskbox.Location = new System.Drawing.Point(667, 12);
            this.taskbox.Name = "taskbox";
            this.taskbox.Size = new System.Drawing.Size(121, 21);
            this.taskbox.TabIndex = 33;
            this.taskbox.SelectedIndexChanged += new System.EventHandler(this.taskbox_SelectedIndexChanged);
            // 
            // tasklbl
            // 
            this.tasklbl.AutoSize = true;
            this.tasklbl.Location = new System.Drawing.Point(583, 15);
            this.tasklbl.Name = "tasklbl";
            this.tasklbl.Size = new System.Drawing.Size(76, 13);
            this.tasklbl.TabIndex = 34;
            this.tasklbl.Text = "Task selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 443);
            this.Controls.Add(this.tasklbl);
            this.Controls.Add(this.taskbox);
            this.Controls.Add(this.numberlbl);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.numberbtn);
            this.Controls.Add(this.resultbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.titletxtbox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.thirdlbl);
            this.Controls.Add(this.thirdtxtbox);
            this.Controls.Add(this.Secondlbl);
            this.Controls.Add(this.secondtxtbox);
            this.Controls.Add(this.firtslbl);
            this.Controls.Add(this.firsttxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox titletxtbox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label thirdlbl;
        private System.Windows.Forms.TextBox thirdtxtbox;
        private System.Windows.Forms.Label Secondlbl;
        private System.Windows.Forms.TextBox secondtxtbox;
        private System.Windows.Forms.Label firtslbl;
        private System.Windows.Forms.TextBox firsttxtbox;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button resultbtn;
        private System.Windows.Forms.Button numberbtn;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label numberlbl;
        private System.Windows.Forms.ComboBox taskbox;
        private System.Windows.Forms.Label tasklbl;
    }
}


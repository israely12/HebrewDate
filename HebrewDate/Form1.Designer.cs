namespace HebrewDate
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbweekday = new System.Windows.Forms.ComboBox();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.cmbmonthday = new System.Windows.Forms.ComboBox();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "כתיבת תאריך";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(57, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "היום בחודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "חודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "שנה";
            // 
            // cmbweekday
            // 
            this.cmbweekday.FormattingEnabled = true;
            this.cmbweekday.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cmbweekday.Location = new System.Drawing.Point(546, 145);
            this.cmbweekday.Name = "cmbweekday";
            this.cmbweekday.Size = new System.Drawing.Size(121, 24);
            this.cmbweekday.TabIndex = 6;
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbmonth.Location = new System.Drawing.Point(241, 145);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(121, 24);
            this.cmbmonth.TabIndex = 7;
            // 
            // cmbmonthday
            // 
            this.cmbmonthday.FormattingEnabled = true;
            this.cmbmonthday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbmonthday.Location = new System.Drawing.Point(397, 145);
            this.cmbmonthday.Name = "cmbmonthday";
            this.cmbmonthday.Size = new System.Drawing.Size(121, 24);
            this.cmbmonthday.TabIndex = 8;
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Items.AddRange(new object[] {
            "תשפ\"ד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז"});
            this.cmbyear.Location = new System.Drawing.Point(91, 145);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(121, 24);
            this.cmbyear.TabIndex = 9;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(148, 214);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(131, 43);
            this.btnwrite.TabIndex = 10;
            this.btnwrite.Text = "כתיבה";
            this.btnwrite.UseVisualStyleBackColor = true;
            
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(272, 328);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(283, 22);
            this.txtresult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.cmbmonthday);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.cmbweekday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbweekday;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.ComboBox cmbmonthday;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TextBox txtresult;
    }
}


namespace _24.InfoGUI_Display
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            button1 = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 120);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(325, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 205);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 0;
            label2.Text = "Surname : ";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(325, 199);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(275, 31);
            txtSurname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 263);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 0;
            label3.Text = "Year of Birth : ";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(325, 260);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(275, 31);
            txtYear.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(325, 377);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BorderStyle = BorderStyle.Fixed3D;
            lblInfo.Location = new Point(325, 314);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(289, 27);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "                                                       ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfo);
            Controls.Add(button1);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtYear;
        private Button button1;
        private Label lblInfo;
    }
}
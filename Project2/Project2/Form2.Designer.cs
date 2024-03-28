namespace Project2
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
            guestName = new TextBox();
            phoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            email = new TextBox();
            label3 = new Label();
            button1 = new Button();
            id = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // guestName
            // 
            guestName.Location = new Point(180, 55);
            guestName.Name = "guestName";
            guestName.Size = new Size(100, 23);
            guestName.TabIndex = 0;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(441, 55);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(100, 23);
            phoneNumber.TabIndex = 1;
            phoneNumber.TextChanged += phoneNumber_TextChanged;
            phoneNumber.Validating += phoneNumber_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 28);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            label2.Click += label2_Click;
            // 
            // email
            // 
            email.Location = new Point(180, 148);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 123);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(337, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id
            // 
            id.FormattingEnabled = true;
            id.Location = new Point(394, 148);
            id.Name = "id";
            id.Size = new Size(121, 23);
            id.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 123);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 8;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 28);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(id);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneNumber);
            Controls.Add(guestName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guestName;
        private TextBox phoneNumber;
        private Label label1;
        private Label label2;
        private TextBox email;
        private Label label3;
        private Button button1;
        private ComboBox id;
        private Label label4;
        private Label label5;
    }
}
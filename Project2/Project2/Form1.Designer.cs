namespace Project2
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
            Type = new ComboBox();
            WiFiAvailable = new ComboBox();
            Availability = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            idbox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Type
            // 
            Type.FormattingEnabled = true;
            Type.Items.AddRange(new object[] { "Gaming PC", "Console", "VR Setup", "", "" });
            Type.Location = new Point(65, 66);
            Type.Name = "Type";
            Type.Size = new Size(121, 23);
            Type.TabIndex = 0;
            // 
            // WiFiAvailable
            // 
            WiFiAvailable.FormattingEnabled = true;
            WiFiAvailable.Items.AddRange(new object[] { "Yes", "No" });
            WiFiAvailable.Location = new Point(447, 66);
            WiFiAvailable.Name = "WiFiAvailable";
            WiFiAvailable.Size = new Size(121, 23);
            WiFiAvailable.TabIndex = 1;
            // 
            // Availability
            // 
            Availability.FormattingEnabled = true;
            Availability.Items.AddRange(new object[] { "Available", "Out of Service" });
            Availability.Location = new Point(257, 66);
            Availability.Name = "Availability";
            Availability.Size = new Size(121, 23);
            Availability.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(379, 216);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(274, 365);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(436, 365);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Reserve";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // idbox
            // 
            idbox.FormattingEnabled = true;
            idbox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            idbox.Location = new Point(610, 66);
            idbox.Name = "idbox";
            idbox.Size = new Size(121, 23);
            idbox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 48);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 48);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Availability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 48);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "WiFiAvailable";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 48);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 10;
            label4.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idbox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Availability);
            Controls.Add(WiFiAvailable);
            Controls.Add(Type);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Type;
        private ComboBox WiFiAvailable;
        private ComboBox Availability;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox idbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
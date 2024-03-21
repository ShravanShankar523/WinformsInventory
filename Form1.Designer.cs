namespace Winforms.Inventory
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
            listBox1 = new ListBox();
            addBtn = new Button();
            deleteBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 36;
            listBox1.Location = new Point(62, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(769, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1038, 86);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 46);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Item";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(1038, 192);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(150, 46);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(1038, 296);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(150, 46);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 603);
            Controls.Add(exitBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button addBtn;
        private Button deleteBtn;
        private Button exitBtn;
    }
}

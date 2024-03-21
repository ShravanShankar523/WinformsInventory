namespace Winforms.Inventory
{
    partial class NewInventoryItem
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
            itemLabel = new Label();
            descLabel = new Label();
            priceLabel = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
            itemTxt = new TextBox();
            descTxt = new TextBox();
            priceTxt = new TextBox();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(187, 114);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(110, 36);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "Item no:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(187, 218);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(151, 36);
            descLabel.TabIndex = 1;
            descLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(187, 310);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(77, 36);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price:";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(265, 488);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 46);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(575, 488);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 46);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // itemTxt
            // 
            itemTxt.Location = new Point(445, 114);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new Size(200, 42);
            itemTxt.TabIndex = 5;
            // 
            // descTxt
            // 
            descTxt.Location = new Point(445, 218);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(408, 42);
            descTxt.TabIndex = 6;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(445, 310);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(200, 42);
            priceTxt.TabIndex = 7;
            // 
            // NewInventoryItem
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 618);
            Controls.Add(priceTxt);
            Controls.Add(descTxt);
            Controls.Add(itemTxt);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(priceLabel);
            Controls.Add(descLabel);
            Controls.Add(itemLabel);
            Name = "NewInventoryItem";
            Text = "NewInventoryItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemLabel;
        private Label descLabel;
        private Label priceLabel;
        private Button SaveBtn;
        private Button CancelBtn;
        private TextBox itemTxt;
        private TextBox descTxt;
        private TextBox priceTxt;
    }
}
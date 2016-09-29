namespace IntroProject
{
    partial class input_gui
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
            this.clearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.AmtLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FillInLabel = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.RadioButton();
            this.CashBtn = new System.Windows.Forms.RadioButton();
            this.DepositBtn = new System.Windows.Forms.RadioButton();
            this.TransTypeLabel = new System.Windows.Forms.Label();
            this.BalLabel = new System.Windows.Forms.Label();
            this.BalAmtLabel = new System.Windows.Forms.Label();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(544, 287);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(421, 287);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 18;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExLabel
            // 
            this.ExLabel.AutoSize = true;
            this.ExLabel.Location = new System.Drawing.Point(176, 224);
            this.ExLabel.Name = "ExLabel";
            this.ExLabel.Size = new System.Drawing.Size(46, 13);
            this.ExLabel.TabIndex = 17;
            this.ExLabel.Text = "0000.00";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.Location = new System.Drawing.Point(107, 164);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(253, 20);
            this.NameTextBox.TabIndex = 16;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(107, 201);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(115, 20);
            this.AmountTextBox.TabIndex = 15;
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.Location = new System.Drawing.Point(107, 246);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(474, 20);
            this.MemoTextBox.TabIndex = 14;
            // 
            // MemoLabel
            // 
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.Location = new System.Drawing.Point(41, 253);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(36, 13);
            this.MemoLabel.TabIndex = 13;
            this.MemoLabel.Text = "Memo";
            // 
            // AmtLabel
            // 
            this.AmtLabel.AutoSize = true;
            this.AmtLabel.Location = new System.Drawing.Point(41, 208);
            this.AmtLabel.Name = "AmtLabel";
            this.AmtLabel.Size = new System.Drawing.Size(58, 13);
            this.AmtLabel.TabIndex = 12;
            this.AmtLabel.Text = "Amount ($)";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(41, 171);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name";
            // 
            // FillInLabel
            // 
            this.FillInLabel.AutoSize = true;
            this.FillInLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillInLabel.Location = new System.Drawing.Point(14, 129);
            this.FillInLabel.Name = "FillInLabel";
            this.FillInLabel.Size = new System.Drawing.Size(346, 23);
            this.FillInLabel.TabIndex = 10;
            this.FillInLabel.Text = "Fill in the Information for your transaction:";
            // 
            // CheckBtn
            // 
            this.CheckBtn.AutoSize = true;
            this.CheckBtn.Location = new System.Drawing.Point(18, 44);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(56, 17);
            this.CheckBtn.TabIndex = 20;
            this.CheckBtn.TabStop = true;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.CheckedChanged += new System.EventHandler(this.CheckBtn_CheckedChanged);
            // 
            // CashBtn
            // 
            this.CashBtn.AutoSize = true;
            this.CashBtn.Location = new System.Drawing.Point(18, 67);
            this.CashBtn.Name = "CashBtn";
            this.CashBtn.Size = new System.Drawing.Size(49, 17);
            this.CashBtn.TabIndex = 21;
            this.CashBtn.TabStop = true;
            this.CashBtn.Text = "Cash";
            this.CashBtn.UseVisualStyleBackColor = true;
            this.CashBtn.CheckedChanged += new System.EventHandler(this.CashBtn_CheckedChanged);
            // 
            // DepositBtn
            // 
            this.DepositBtn.AutoSize = true;
            this.DepositBtn.Location = new System.Drawing.Point(18, 90);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(61, 17);
            this.DepositBtn.TabIndex = 22;
            this.DepositBtn.TabStop = true;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            this.DepositBtn.CheckedChanged += new System.EventHandler(this.DepositBtn_CheckedChanged);
            // 
            // TransTypeLabel
            // 
            this.TransTypeLabel.AutoSize = true;
            this.TransTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.TransTypeLabel.Location = new System.Drawing.Point(14, 9);
            this.TransTypeLabel.Name = "TransTypeLabel";
            this.TransTypeLabel.Size = new System.Drawing.Size(219, 23);
            this.TransTypeLabel.TabIndex = 23;
            this.TransTypeLabel.Text = "Choose a transaction type:";
            // 
            // BalLabel
            // 
            this.BalLabel.AutoSize = true;
            this.BalLabel.Location = new System.Drawing.Point(395, 101);
            this.BalLabel.Name = "BalLabel";
            this.BalLabel.Size = new System.Drawing.Size(49, 13);
            this.BalLabel.TabIndex = 24;
            this.BalLabel.Text = "Balance:";
            // 
            // BalAmtLabel
            // 
            this.BalAmtLabel.AutoSize = true;
            this.BalAmtLabel.Location = new System.Drawing.Point(450, 101);
            this.BalAmtLabel.Name = "BalAmtLabel";
            this.BalAmtLabel.Size = new System.Drawing.Size(0, 13);
            this.BalAmtLabel.TabIndex = 25;
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.Location = new System.Drawing.Point(80, 44);
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Size = new System.Drawing.Size(87, 17);
            this.ShowCheckBox.TabIndex = 26;
            this.ShowCheckBox.Text = "Show Check";
            this.ShowCheckBox.UseVisualStyleBackColor = true;
            this.ShowCheckBox.Visible = false;
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(593, 9);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(114, 23);
            this.ChooseBtn.TabIndex = 27;
            this.ChooseBtn.Text = "Choose Checkbook";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // input_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 330);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.ShowCheckBox);
            this.Controls.Add(this.BalAmtLabel);
            this.Controls.Add(this.BalLabel);
            this.Controls.Add(this.TransTypeLabel);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.CashBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ExLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.AmtLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FillInLabel);
            this.Name = "input_gui";
            this.Text = "Transaction Form";
            this.Load += new System.EventHandler(this.input_gui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ExLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.Label AmtLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FillInLabel;
        private System.Windows.Forms.RadioButton CheckBtn;
        private System.Windows.Forms.RadioButton CashBtn;
        private System.Windows.Forms.RadioButton DepositBtn;
        private System.Windows.Forms.Label TransTypeLabel;
        private System.Windows.Forms.Label BalLabel;
        private System.Windows.Forms.Label BalAmtLabel;
        private System.Windows.Forms.CheckBox ShowCheckBox;
        private System.Windows.Forms.Button ChooseBtn;
    }
}
namespace IntroProject
{
    partial class CheckbookSelectionForm
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
            this.OpenBtn = new System.Windows.Forms.RadioButton();
            this.NewBtn = new System.Windows.Forms.RadioButton();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.BalanceText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.Location = new System.Drawing.Point(38, 40);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(148, 17);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.TabStop = true;
            this.OpenBtn.Text = "Open Existing Checkbook";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.CheckedChanged += new System.EventHandler(this.OpenBtn_CheckedChanged);
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSize = true;
            this.NewBtn.Location = new System.Drawing.Point(38, 112);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(105, 17);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.TabStop = true;
            this.NewBtn.Text = "New Checkbook";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.CheckedChanged += new System.EventHandler(this.NewBtn_CheckedChanged);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(192, 34);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenFileBtn.TabIndex = 3;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Visible = false;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(38, 161);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(174, 20);
            this.NameText.TabIndex = 5;
            this.NameText.Visible = false;
            // 
            // BalanceText
            // 
            this.BalanceText.Location = new System.Drawing.Point(38, 204);
            this.BalanceText.Name = "BalanceText";
            this.BalanceText.Size = new System.Drawing.Size(174, 20);
            this.BalanceText.TabIndex = 6;
            this.BalanceText.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(35, 145);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(178, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Checkbook Name (no file extension)";
            this.NameLabel.Visible = false;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(38, 188);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(133, 13);
            this.BalanceLabel.TabIndex = 8;
            this.BalanceLabel.Text = "Starting Balance (0000.00)";
            this.BalanceLabel.Visible = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(248, 245);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 9;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(38, 63);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.ReadOnly = true;
            this.FileNameText.Size = new System.Drawing.Size(303, 20);
            this.FileNameText.TabIndex = 10;
            this.FileNameText.Visible = false;
            // 
            // CheckbookSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 289);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BalanceText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.OpenBtn);
            this.Name = "CheckbookSelectionForm";
            this.Text = "CheckbookSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OpenBtn;
        private System.Windows.Forms.RadioButton NewBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox BalanceText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox FileNameText;
    }
}
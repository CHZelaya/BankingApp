namespace BankingGui
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
            ListAccounts = new ListBox();
            label1 = new Label();
            TextBox_Amount = new TextBox();
            label2 = new Label();
            Button_Deposit = new Button();
            Button_Withdraw = new Button();
            SuspendLayout();
            // 
            // ListAccounts
            // 
            ListAccounts.FormattingEnabled = true;
            ListAccounts.ItemHeight = 15;
            ListAccounts.Location = new Point(52, 40);
            ListAccounts.Name = "ListAccounts";
            ListAccounts.Size = new Size(277, 244);
            ListAccounts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "List of Accounts";
            // 
            // TextBox_Amount
            // 
            TextBox_Amount.Location = new Point(460, 74);
            TextBox_Amount.Name = "TextBox_Amount";
            TextBox_Amount.Size = new Size(100, 23);
            TextBox_Amount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 40);
            label2.Name = "label2";
            label2.Size = new Size(222, 15);
            label2.TabIndex = 3;
            label2.Text = "Input the amount to deposit or withdraw";
            // 
            // Button_Deposit
            // 
            Button_Deposit.Location = new Point(394, 103);
            Button_Deposit.Name = "Button_Deposit";
            Button_Deposit.Size = new Size(75, 23);
            Button_Deposit.TabIndex = 4;
            Button_Deposit.Text = "&Desposit";
            Button_Deposit.UseVisualStyleBackColor = true;
            Button_Deposit.Click += Button_Deposit_Click;
            // 
            // Button_Withdraw
            // 
            Button_Withdraw.Location = new Point(541, 103);
            Button_Withdraw.Name = "Button_Withdraw";
            Button_Withdraw.Size = new Size(75, 23);
            Button_Withdraw.TabIndex = 5;
            Button_Withdraw.Text = "&Withdraw";
            Button_Withdraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(687, 400);
            Controls.Add(Button_Withdraw);
            Controls.Add(Button_Deposit);
            Controls.Add(label2);
            Controls.Add(TextBox_Amount);
            Controls.Add(label1);
            Controls.Add(ListAccounts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListAccounts;
        private Label label1;
        private TextBox TextBox_Amount;
        private Label label2;
        private Button Button_Deposit;
        private Button Button_Withdraw;
    }
}

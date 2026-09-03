namespace BankAccountApp
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
            Owner = new Label();
            Amount = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BanksAccountDataGrid = new DataGridView();
            CreateBtn = new Button();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            InterestRate = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BanksAccountDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Owner.Location = new Point(14, 36);
            Owner.Name = "Owner";
            Owner.Size = new Size(101, 37);
            Owner.TabIndex = 0;
            Owner.Text = "Owner:";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(14, 460);
            Amount.Name = "Amount";
            Amount.Size = new Size(118, 37);
            Amount.TabIndex = 1;
            Amount.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(127, 45);
            OwnerTxt.Margin = new Padding(3, 4, 3, 4);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(233, 27);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(127, 469);
            AmountNum.Margin = new Padding(3, 4, 3, 4);
            AmountNum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(253, 27);
            AmountNum.TabIndex = 3;
            // 
            // BanksAccountDataGrid
            // 
            BanksAccountDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BanksAccountDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BanksAccountDataGrid.Location = new Point(451, 45);
            BanksAccountDataGrid.Margin = new Padding(3, 4, 3, 4);
            BanksAccountDataGrid.Name = "BanksAccountDataGrid";
            BanksAccountDataGrid.RowHeadersWidth = 51;
            BanksAccountDataGrid.Size = new Size(449, 380);
            BanksAccountDataGrid.TabIndex = 4;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(141, 185);
            CreateBtn.Margin = new Padding(3, 4, 3, 4);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(219, 44);
            CreateBtn.TabIndex = 5;
            CreateBtn.Text = "Create Account";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(464, 452);
            DepositBtn.Margin = new Padding(3, 4, 3, 4);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(184, 44);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(700, 452);
            WithdrawBtn.Margin = new Padding(3, 4, 3, 4);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(174, 44);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // InterestRate
            // 
            InterestRate.AutoSize = true;
            InterestRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InterestRate.Location = new Point(14, 95);
            InterestRate.Name = "InterestRate";
            InterestRate.Size = new Size(154, 28);
            InterestRate.TabIndex = 8;
            InterestRate.Text = "Interest Rate (%)";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(210, 96);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(150, 27);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(InterestRateNum);
            Controls.Add(InterestRate);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateBtn);
            Controls.Add(BanksAccountDataGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(Amount);
            Controls.Add(Owner);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BanksAccountDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Owner;
        private Label Amount;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BanksAccountDataGrid;
        private Button CreateBtn;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Label InterestRate;
        private NumericUpDown InterestRateNum;
    }
}

namespace JRYMonthlyCarPaymentCalculator
{
    partial class MonthlyPaymentCalculator
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchasePriceTB = new System.Windows.Forms.TextBox();
            this.DownPaymentTB = new System.Windows.Forms.TextBox();
            this.PurchasePriceLbl = new System.Windows.Forms.Label();
            this.DownPaymentLbl = new System.Windows.Forms.Label();
            this.AnnualInterestTB = new System.Windows.Forms.TextBox();
            this.AnnualInterestLbl = new System.Windows.Forms.Label();
            this.LoanLengthTB = new System.Windows.Forms.TextBox();
            this.LoanLengthLbl = new System.Windows.Forms.Label();
            this.AmountToFinanceLbl = new System.Windows.Forms.Label();
            this.MonthlyPaymentLbl = new System.Windows.Forms.Label();
            this.AmountToFinanceTB = new System.Windows.Forms.TextBox();
            this.MonthlyPaymentTB = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Blackadder ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.CalculateBtn.Location = new System.Drawing.Point(226, 208);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(102, 41);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "Calculate ";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monthly Car Payment Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PurchasePriceTB
            // 
            this.PurchasePriceTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F);
            this.PurchasePriceTB.Location = new System.Drawing.Point(226, 71);
            this.PurchasePriceTB.Name = "PurchasePriceTB";
            this.PurchasePriceTB.Size = new System.Drawing.Size(160, 25);
            this.PurchasePriceTB.TabIndex = 2;
            // 
            // DownPaymentTB
            // 
            this.DownPaymentTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F);
            this.DownPaymentTB.Location = new System.Drawing.Point(226, 105);
            this.DownPaymentTB.Name = "DownPaymentTB";
            this.DownPaymentTB.Size = new System.Drawing.Size(160, 25);
            this.DownPaymentTB.TabIndex = 3;
            // 
            // PurchasePriceLbl
            // 
            this.PurchasePriceLbl.AutoSize = true;
            this.PurchasePriceLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.PurchasePriceLbl.Location = new System.Drawing.Point(87, 78);
            this.PurchasePriceLbl.Name = "PurchasePriceLbl";
            this.PurchasePriceLbl.Size = new System.Drawing.Size(133, 15);
            this.PurchasePriceLbl.TabIndex = 4;
            this.PurchasePriceLbl.Text = "Purchase price";
            // 
            // DownPaymentLbl
            // 
            this.DownPaymentLbl.AutoSize = true;
            this.DownPaymentLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.DownPaymentLbl.Location = new System.Drawing.Point(42, 112);
            this.DownPaymentLbl.Name = "DownPaymentLbl";
            this.DownPaymentLbl.Size = new System.Drawing.Size(178, 15);
            this.DownPaymentLbl.TabIndex = 5;
            this.DownPaymentLbl.Text = "Down payment amount";
            // 
            // AnnualInterestTB
            // 
            this.AnnualInterestTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F);
            this.AnnualInterestTB.Location = new System.Drawing.Point(226, 140);
            this.AnnualInterestTB.Name = "AnnualInterestTB";
            this.AnnualInterestTB.Size = new System.Drawing.Size(160, 25);
            this.AnnualInterestTB.TabIndex = 6;
            // 
            // AnnualInterestLbl
            // 
            this.AnnualInterestLbl.AutoSize = true;
            this.AnnualInterestLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.AnnualInterestLbl.Location = new System.Drawing.Point(42, 148);
            this.AnnualInterestLbl.Name = "AnnualInterestLbl";
            this.AnnualInterestLbl.Size = new System.Drawing.Size(178, 15);
            this.AnnualInterestLbl.TabIndex = 7;
            this.AnnualInterestLbl.Text = "Annual interest (%)";
            // 
            // LoanLengthTB
            // 
            this.LoanLengthTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F);
            this.LoanLengthTB.Location = new System.Drawing.Point(226, 174);
            this.LoanLengthTB.Name = "LoanLengthTB";
            this.LoanLengthTB.Size = new System.Drawing.Size(160, 25);
            this.LoanLengthTB.TabIndex = 8;
            // 
            // LoanLengthLbl
            // 
            this.LoanLengthLbl.AutoSize = true;
            this.LoanLengthLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.LoanLengthLbl.Location = new System.Drawing.Point(6, 182);
            this.LoanLengthLbl.Name = "LoanLengthLbl";
            this.LoanLengthLbl.Size = new System.Drawing.Size(214, 15);
            this.LoanLengthLbl.TabIndex = 9;
            this.LoanLengthLbl.Text = "Length of loan (months)";
            // 
            // AmountToFinanceLbl
            // 
            this.AmountToFinanceLbl.AutoSize = true;
            this.AmountToFinanceLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountToFinanceLbl.Location = new System.Drawing.Point(410, 79);
            this.AmountToFinanceLbl.Name = "AmountToFinanceLbl";
            this.AmountToFinanceLbl.Size = new System.Drawing.Size(160, 15);
            this.AmountToFinanceLbl.TabIndex = 10;
            this.AmountToFinanceLbl.Text = "Amount to finance";
            // 
            // MonthlyPaymentLbl
            // 
            this.MonthlyPaymentLbl.AutoSize = true;
            this.MonthlyPaymentLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyPaymentLbl.Location = new System.Drawing.Point(428, 112);
            this.MonthlyPaymentLbl.Name = "MonthlyPaymentLbl";
            this.MonthlyPaymentLbl.Size = new System.Drawing.Size(142, 15);
            this.MonthlyPaymentLbl.TabIndex = 11;
            this.MonthlyPaymentLbl.Text = "Monthly payment";
            // 
            // AmountToFinanceTB
            // 
            this.AmountToFinanceTB.Enabled = false;
            this.AmountToFinanceTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.AmountToFinanceTB.Location = new System.Drawing.Point(576, 71);
            this.AmountToFinanceTB.Name = "AmountToFinanceTB";
            this.AmountToFinanceTB.Size = new System.Drawing.Size(170, 25);
            this.AmountToFinanceTB.TabIndex = 12;
            // 
            // MonthlyPaymentTB
            // 
            this.MonthlyPaymentTB.Enabled = false;
            this.MonthlyPaymentTB.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold);
            this.MonthlyPaymentTB.Location = new System.Drawing.Point(576, 105);
            this.MonthlyPaymentTB.Name = "MonthlyPaymentTB";
            this.MonthlyPaymentTB.Size = new System.Drawing.Size(170, 25);
            this.MonthlyPaymentTB.TabIndex = 13;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Blackadder ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(576, 139);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(72, 38);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_Click);
            // 
            // MonthlyPaymentCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 261);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MonthlyPaymentTB);
            this.Controls.Add(this.AmountToFinanceTB);
            this.Controls.Add(this.MonthlyPaymentLbl);
            this.Controls.Add(this.AmountToFinanceLbl);
            this.Controls.Add(this.LoanLengthLbl);
            this.Controls.Add(this.LoanLengthTB);
            this.Controls.Add(this.AnnualInterestLbl);
            this.Controls.Add(this.AnnualInterestTB);
            this.Controls.Add(this.DownPaymentLbl);
            this.Controls.Add(this.PurchasePriceLbl);
            this.Controls.Add(this.DownPaymentTB);
            this.Controls.Add(this.PurchasePriceTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateBtn);
            this.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MonthlyPaymentCalculator";
            this.Text = "Monthly Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PurchasePriceTB;
        private System.Windows.Forms.TextBox DownPaymentTB;
        private System.Windows.Forms.Label PurchasePriceLbl;
        private System.Windows.Forms.Label DownPaymentLbl;
        private System.Windows.Forms.TextBox AnnualInterestTB;
        private System.Windows.Forms.Label AnnualInterestLbl;
        private System.Windows.Forms.TextBox LoanLengthTB;
        private System.Windows.Forms.Label LoanLengthLbl;
        private System.Windows.Forms.Label AmountToFinanceLbl;
        private System.Windows.Forms.Label MonthlyPaymentLbl;
        private System.Windows.Forms.TextBox AmountToFinanceTB;
        private System.Windows.Forms.TextBox MonthlyPaymentTB;
        private System.Windows.Forms.Button CloseBtn;
    }
}


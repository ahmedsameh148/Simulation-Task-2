namespace NewspaperSellerSimulation
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DayNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomNumberForTypeOfNewsday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfNewsDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomNumberForDemond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueFromSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostProfitFromExcessDemond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalvageFromSaleScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TotalSaleRevernue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostOfNewsPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfitFromExcessDemond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalvageFromSaleScrapPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDaysHavingExcessDemond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDaysHavingUnsoldPaper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayNumber,
            this.RandomNumberForTypeOfNewsday,
            this.TypeOfNewsDay,
            this.RandomNumberForDemond,
            this.Demond,
            this.RevenueFromSale,
            this.LostProfitFromExcessDemond,
            this.SalvageFromSaleScrap,
            this.DailyProfit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // DayNumber
            // 
            this.DayNumber.HeaderText = "Day Number";
            this.DayNumber.Name = "DayNumber";
            // 
            // RandomNumberForTypeOfNewsday
            // 
            this.RandomNumberForTypeOfNewsday.HeaderText = "Random Number For Type Of Newsday";
            this.RandomNumberForTypeOfNewsday.Name = "RandomNumberForTypeOfNewsday";
            // 
            // TypeOfNewsDay
            // 
            this.TypeOfNewsDay.HeaderText = "Type Of News Day";
            this.TypeOfNewsDay.Name = "TypeOfNewsDay";
            // 
            // RandomNumberForDemond
            // 
            this.RandomNumberForDemond.HeaderText = "Random Number For Demond";
            this.RandomNumberForDemond.Name = "RandomNumberForDemond";
            // 
            // Demond
            // 
            this.Demond.HeaderText = "Demond";
            this.Demond.Name = "Demond";
            // 
            // RevenueFromSale
            // 
            this.RevenueFromSale.HeaderText = "Revenue From Sale";
            this.RevenueFromSale.Name = "RevenueFromSale";
            // 
            // LostProfitFromExcessDemond
            // 
            this.LostProfitFromExcessDemond.HeaderText = "LostProfit From Excess Demond";
            this.LostProfitFromExcessDemond.Name = "LostProfitFromExcessDemond";
            // 
            // SalvageFromSaleScrap
            // 
            this.SalvageFromSaleScrap.HeaderText = "Salvage From Sale Scrap";
            this.SalvageFromSaleScrap.Name = "SalvageFromSaleScrap";
            // 
            // DailyProfit
            // 
            this.DailyProfit.HeaderText = "Daily Profit";
            this.DailyProfit.Name = "DailyProfit";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalSaleRevernue,
            this.TotalCostOfNewsPaper,
            this.TotalProfitFromExcessDemond,
            this.TotalSalvageFromSaleScrapPaper,
            this.NetProfit,
            this.NumberOfDaysHavingExcessDemond,
            this.NumberOfDaysHavingUnsoldPaper});
            this.dataGridView2.Location = new System.Drawing.Point(12, 398);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(944, 96);
            this.dataGridView2.TabIndex = 1;
            // 
            // TotalSaleRevernue
            // 
            this.TotalSaleRevernue.FillWeight = 125F;
            this.TotalSaleRevernue.HeaderText = "Total Sale Revenue";
            this.TotalSaleRevernue.Name = "TotalSaleRevernue";
            this.TotalSaleRevernue.Width = 125;
            // 
            // TotalCostOfNewsPaper
            // 
            this.TotalCostOfNewsPaper.FillWeight = 125F;
            this.TotalCostOfNewsPaper.HeaderText = "Total Cost Of News Paper";
            this.TotalCostOfNewsPaper.Name = "TotalCostOfNewsPaper";
            this.TotalCostOfNewsPaper.Width = 125;
            // 
            // TotalProfitFromExcessDemond
            // 
            this.TotalProfitFromExcessDemond.FillWeight = 125F;
            this.TotalProfitFromExcessDemond.HeaderText = "Total Profit From Excess Demond";
            this.TotalProfitFromExcessDemond.Name = "TotalProfitFromExcessDemond";
            this.TotalProfitFromExcessDemond.Width = 125;
            // 
            // TotalSalvageFromSaleScrapPaper
            // 
            this.TotalSalvageFromSaleScrapPaper.FillWeight = 125F;
            this.TotalSalvageFromSaleScrapPaper.HeaderText = "Total Salvage From Sale Scrap Paper";
            this.TotalSalvageFromSaleScrapPaper.Name = "TotalSalvageFromSaleScrapPaper";
            this.TotalSalvageFromSaleScrapPaper.Width = 125;
            // 
            // NetProfit
            // 
            this.NetProfit.FillWeight = 125F;
            this.NetProfit.HeaderText = "Net Profit";
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Width = 125;
            // 
            // NumberOfDaysHavingExcessDemond
            // 
            this.NumberOfDaysHavingExcessDemond.FillWeight = 125F;
            this.NumberOfDaysHavingExcessDemond.HeaderText = "Number Of Days Having Excess Demond";
            this.NumberOfDaysHavingExcessDemond.Name = "NumberOfDaysHavingExcessDemond";
            this.NumberOfDaysHavingExcessDemond.Width = 125;
            // 
            // NumberOfDaysHavingUnsoldPaper
            // 
            this.NumberOfDaysHavingUnsoldPaper.FillWeight = 150F;
            this.NumberOfDaysHavingUnsoldPaper.HeaderText = "Number Of Days Having Unsold Paper";
            this.NumberOfDaysHavingUnsoldPaper.Name = "NumberOfDaysHavingUnsoldPaper";
            this.NumberOfDaysHavingUnsoldPaper.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run Test Case";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation Table";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Performance Measures";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNumberForTypeOfNewsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfNewsDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNumberForDemond;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demond;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueFromSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostProfitFromExcessDemond;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalvageFromSaleScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyProfit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSaleRevernue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostOfNewsPaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfitFromExcessDemond;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalvageFromSaleScrapPaper;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDaysHavingExcessDemond;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDaysHavingUnsoldPaper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
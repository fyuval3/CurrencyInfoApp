namespace CurrencyInfoApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            currencyControl1 = new CurrencyControl();
            currencyControl2 = new CurrencyControl();
            currencyControl3 = new CurrencyControl();
            currencyControl4 = new CurrencyControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // currencyControl1
            // 
            currencyControl1.AutoSize = true;
            currencyControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            currencyControl1.FromCurrency = CurrencyFetching.eCurrency.USD;
            currencyControl1.LastUpdateText = "               [Date, Time]";
            currencyControl1.Location = new Point(15, 15);
            currencyControl1.Margin = new Padding(8);
            currencyControl1.Name = "currencyControl1";
            currencyControl1.RateText = "Rate";
            currencyControl1.Size = new Size(189, 42);
            currencyControl1.TabIndex = 0;
            currencyControl1.ToCurrency = CurrencyFetching.eCurrency.ILS;
            // 
            // currencyControl2
            // 
            currencyControl2.AutoSize = true;
            currencyControl2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            currencyControl2.FromCurrency = CurrencyFetching.eCurrency.GBP;
            currencyControl2.LastUpdateText = "                [Date, Time]";
            currencyControl2.Location = new Point(15, 73);
            currencyControl2.Margin = new Padding(8);
            currencyControl2.Name = "currencyControl2";
            currencyControl2.RateText = "Rate";
            currencyControl2.Size = new Size(197, 42);
            currencyControl2.TabIndex = 1;
            currencyControl2.ToCurrency = CurrencyFetching.eCurrency.EUR;
            // 
            // currencyControl3
            // 
            currencyControl3.AutoSize = true;
            currencyControl3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            currencyControl3.FromCurrency = CurrencyFetching.eCurrency.EUR;
            currencyControl3.LastUpdateText = "                 [Date, Time]";
            currencyControl3.Location = new Point(15, 131);
            currencyControl3.Margin = new Padding(8);
            currencyControl3.Name = "currencyControl3";
            currencyControl3.RateText = "Rate";
            currencyControl3.Size = new Size(195, 42);
            currencyControl3.TabIndex = 2;
            currencyControl3.ToCurrency = CurrencyFetching.eCurrency.JPY;
            // 
            // currencyControl4
            // 
            currencyControl4.AutoSize = true;
            currencyControl4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            currencyControl4.FromCurrency = CurrencyFetching.eCurrency.EUR;
            currencyControl4.LastUpdateText = "                  [Date, Time]";
            currencyControl4.Location = new Point(15, 189);
            currencyControl4.Margin = new Padding(8);
            currencyControl4.Name = "currencyControl4";
            currencyControl4.RateText = "Rate";
            currencyControl4.Size = new Size(198, 42);
            currencyControl4.TabIndex = 3;
            currencyControl4.ToCurrency = CurrencyFetching.eCurrency.USD;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(currencyControl1);
            flowLayoutPanel1.Controls.Add(currencyControl2);
            flowLayoutPanel1.Controls.Add(currencyControl3);
            flowLayoutPanel1.Controls.Add(currencyControl4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(7);
            flowLayoutPanel1.Size = new Size(933, 494);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(933, 494);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Info";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CurrencyControl currencyControl1;
        private CurrencyControl currencyControl2;
        private CurrencyControl currencyControl3;
        private CurrencyControl currencyControl4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
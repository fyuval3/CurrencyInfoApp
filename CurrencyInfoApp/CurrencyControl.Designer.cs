namespace CurrencyInfoApp
{
    partial class CurrencyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            m_CurrenciesText = new Label();
            m_RateText = new Label();
            m_LastUpdateText = new Label();
            SuspendLayout();
            // 
            // m_CurrenciesText
            // 
            m_CurrenciesText.AutoSize = true;
            m_CurrenciesText.Dock = DockStyle.Left;
            m_CurrenciesText.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            m_CurrenciesText.Location = new Point(0, 0);
            m_CurrenciesText.Name = "m_CurrenciesText";
            m_CurrenciesText.Size = new Size(115, 27);
            m_CurrenciesText.TabIndex = 3;
            m_CurrenciesText.Text = "Currencies:";
            // 
            // m_RateText
            // 
            m_RateText.AutoSize = true;
            m_RateText.Dock = DockStyle.Fill;
            m_RateText.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            m_RateText.Location = new Point(115, 0);
            m_RateText.Name = "m_RateText";
            m_RateText.Size = new Size(53, 27);
            m_RateText.TabIndex = 4;
            m_RateText.Text = "Rate";
            // 
            // m_LastUpdateText
            // 
            m_LastUpdateText.AutoSize = true;
            m_LastUpdateText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            m_LastUpdateText.Location = new Point(0, 27);
            m_LastUpdateText.Name = "m_LastUpdateText";
            m_LastUpdateText.Size = new Size(141, 15);
            m_LastUpdateText.TabIndex = 5;
            m_LastUpdateText.Text = "Updated on: [Date, Time]";
            // 
            // CurrencyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(m_LastUpdateText);
            Controls.Add(m_RateText);
            Controls.Add(m_CurrenciesText);
            Name = "CurrencyControl";
            Size = new Size(168, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label m_CurrenciesText;
        private Label m_RateText;
        private Label m_LastUpdateText;
    }
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyControl));
            m_CurrenciesText = new Label();
            m_RateText = new Label();
            m_LastUpdateText = new Label();
            m_CopyButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // m_CurrenciesText
            // 
            m_CurrenciesText.AutoSize = true;
            m_CurrenciesText.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            m_CurrenciesText.Location = new Point(0, 0);
            m_CurrenciesText.Margin = new Padding(0, 0, 3, 0);
            m_CurrenciesText.Name = "m_CurrenciesText";
            m_CurrenciesText.Size = new Size(115, 27);
            m_CurrenciesText.TabIndex = 3;
            m_CurrenciesText.Text = "Currencies:";
            // 
            // m_RateText
            // 
            m_RateText.AutoSize = true;
            m_RateText.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            m_RateText.Location = new Point(121, 0);
            m_RateText.Name = "m_RateText";
            m_RateText.Size = new Size(83, 27);
            m_RateText.TabIndex = 4;
            m_RateText.Text = "Loading";
            // 
            // m_LastUpdateText
            // 
            m_LastUpdateText.AutoSize = true;
            m_LastUpdateText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            m_LastUpdateText.Location = new Point(3, 27);
            m_LastUpdateText.Name = "m_LastUpdateText";
            m_LastUpdateText.Size = new Size(73, 15);
            m_LastUpdateText.TabIndex = 5;
            m_LastUpdateText.Text = "Updated on:";
            // 
            // m_CopyButton
            // 
            m_CopyButton.BackColor = SystemColors.ActiveCaption;
            m_CopyButton.BackgroundImage = (Image)resources.GetObject("m_CopyButton.BackgroundImage");
            m_CopyButton.BackgroundImageLayout = ImageLayout.Stretch;
            m_CopyButton.Location = new Point(208, 0);
            m_CopyButton.Margin = new Padding(1, 0, 3, 0);
            m_CopyButton.Name = "m_CopyButton";
            m_CopyButton.Size = new Size(27, 27);
            m_CopyButton.TabIndex = 6;
            m_CopyButton.UseVisualStyleBackColor = false;
            m_CopyButton.Click += copyButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(m_CurrenciesText);
            flowLayoutPanel1.Controls.Add(m_RateText);
            flowLayoutPanel1.Controls.Add(m_CopyButton);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 0, 3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(238, 27);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Controls.Add(m_LastUpdateText);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(241, 42);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // CurrencyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flowLayoutPanel2);
            Margin = new Padding(8);
            Name = "CurrencyControl";
            Size = new Size(241, 42);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label m_CurrenciesText;
        private Label m_RateText;
        private Label m_LastUpdateText;
        private Button m_CopyButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}

using CurrencyFetching;

namespace CurrencyInfoApp
{
    public partial class CurrencyControl : UserControl
    {
        private eCurrency m_FromCurrency;
        private eCurrency m_ToCurrency;

        public eCurrency FromCurrency
        {
            get
            {
                return m_FromCurrency;
            }

            set
            {
                m_FromCurrency = value;
                updateCurrenciesText();
            }
        }

        public eCurrency ToCurrency
        {
            get
            {
                return m_ToCurrency;
            }

            set
            {
                m_ToCurrency = value;
                updateCurrenciesText();
            }
        }

        public string CurrenciesText
        {
            get
            {
                return m_CurrenciesText.Text.Substring(0, m_CurrenciesText.Text.Length - 1);
            }
        }

        public string RateText
        {
            get
            {
                return m_RateText.Text;
            }

            set
            {
                m_RateText.Text = value;
            }
        }

        public string LastUpdateText
        {
            get
            {
                return m_LastUpdateText.Text.Substring(m_LastUpdateText.Text.IndexOf(':') + 1);
            }

            set
            {
                m_LastUpdateText.Text = string.Format("Updated on: {0}", value);
            }
        }

        public CurrencyControl()
        {
            InitializeComponent();
        }

        private void updateCurrenciesText()
        {
            m_CurrenciesText.Text = $"{m_FromCurrency}/{m_ToCurrency}:";
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(m_RateText.Text);
        }
    }
}

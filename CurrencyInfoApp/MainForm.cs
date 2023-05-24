using System.Data.SQLite;
using CurrencyFetching;

namespace CurrencyInfoApp
{
    public partial class MainForm : Form
    {
        private const string k_CurrenciesTableName = "Currencies";
        private const int k_DataFetchingIntervalInSeconds = 10;
        private readonly SQLiteConnection r_SQLConnection;
        private readonly CancellationTokenSource r_DataFetchingCancellationTokenSource;
        private readonly Thread r_DataFetchingThread;
        private CurrencyControl[] m_CurrencyConrols;

        public MainForm()
        {
            InitializeComponent();

            m_CurrencyConrols = new CurrencyControl[]
            {
                currencyControl1, currencyControl2, currencyControl3, currencyControl4,
            };

            r_SQLConnection = new SQLiteConnection("Data Source=Currencies.db;Version=3;");
            r_SQLConnection.Open();

            r_DataFetchingCancellationTokenSource = new();
            r_DataFetchingThread = new Thread(new ThreadStart(() => continuouslyFetchCurrenciesInfo(r_DataFetchingCancellationTokenSource.Token)));

            createCurrenciesTableIfNotExists();

            populateCurrencyControlsFromDatabase();

            startDataFetchingThread();

            FormClosed += MainForm_FormClosed;
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            r_DataFetchingCancellationTokenSource.Cancel();
            r_DataFetchingCancellationTokenSource.Dispose();

            if (r_DataFetchingThread.ThreadState == ThreadState.WaitSleepJoin)
            {
                r_DataFetchingThread.Interrupt();
            }

            r_DataFetchingThread.Join();
            r_SQLConnection.Dispose();
        }

        private void startDataFetchingThread()
        {
            r_DataFetchingThread.Start();
        }

        private void continuouslyFetchCurrenciesInfo(CancellationToken i_CancellationToken)
        {
            try
            {
                while (!i_CancellationToken.IsCancellationRequested)
                {
                    foreach (CurrencyControl control in m_CurrencyConrols)
                    {
                        if (i_CancellationToken.IsCancellationRequested)
                        {
                            break;
                        }

                        string currencyQuote = control.CurrenciesText;
                        string rate = string.Empty;

                        rate = CurrencyFetcher.GetCurrency(control.FromCurrency, control.ToCurrency);

                        if (!string.IsNullOrEmpty(rate))
                        {
                            string lastUpdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                            control.BeginInvoke(new Action(() =>
                            {
                                control.RateText = rate;
                                control.LastUpdateText = lastUpdate;
                            }));

                            updateDatabaseWith(currencyQuote, rate, lastUpdate);
                        }
                    }

                    if (!i_CancellationToken.IsCancellationRequested)
                    {
                        Thread.Sleep(k_DataFetchingIntervalInSeconds * 1000); // Wait for 'k_DataFetchingIntervalInSeconds' seconds.
                    }
                }
            }
            catch (ThreadInterruptedException)
            {
                return;
            }
        }

        private void updateDatabaseWith(string i_CurrencyQuote, string i_Rate, string i_LastUpdate)
        {
            string replaceQuery = $"REPLACE INTO {k_CurrenciesTableName} (CurrencyQuote, Rate, LastUpdate) VALUES ('{i_CurrencyQuote}', '{i_Rate}', '{i_LastUpdate}')";
            using (SQLiteCommand replaceCommand = new SQLiteCommand(replaceQuery, r_SQLConnection))
            {
                replaceCommand.ExecuteNonQuery();
            }
        }

        private void populateCurrencyControlsFromDatabase()
        {
            foreach (CurrencyControl currencyControl in m_CurrencyConrols)
            {
                string currencyQuote = currencyControl.CurrenciesText;
                string query = $"SELECT * FROM {k_CurrenciesTableName} WHERE CurrencyQuote='{currencyQuote}'";

                using (SQLiteCommand command = new SQLiteCommand(query, r_SQLConnection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string rate = reader.GetString(1);
                            string lastUpdate = reader.GetString(2);

                            currencyControl.RateText = rate;
                            currencyControl.LastUpdateText = lastUpdate;
                        }
                    }
                }
            }
        }

        private void createCurrenciesTableIfNotExists()
        {
            string checkTableQuery = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{k_CurrenciesTableName}'";
            using (SQLiteCommand checkTableCommand = new SQLiteCommand(checkTableQuery, r_SQLConnection))
            {
                object result = checkTableCommand.ExecuteScalar();

                // If the table does not exist, create it
                if (result == null)
                {
                    string createTableQuery = $"CREATE TABLE {k_CurrenciesTableName} (CurrencyQuote TEXT PRIMARY KEY, Rate TEXT, LastUpdate TEXT)";
                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, r_SQLConnection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
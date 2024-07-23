using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelegramGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int score;
        public int clickPower = 1;
        public int autoClickPower;
        



        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        public int Score
        {
            get => score;
            set
            {
                score = value;
                UpdateUI();
            }
        }

        

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            score += clickPower;
            UpdateUI();
        }

        

        private void UpdateUI()
        {
            ScoreText.Text = score.ToString();
        }

        public void AddClickPower(int power)
        {
            clickPower += power;
        }

        public void AddAutoClickPower(int power)
        {
            autoClickPower += power;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TelegramGame
{
    /// <summary>
    /// Interaction logic for UpgradesWindow.xaml
    /// </summary>
    public partial class UpgradesWindow : Window
    {
        private MainWindow mainWindow;
        private List<Upgrade> upgradesList;

        public UpgradesWindow()
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            InitializeUpgrades();
            DisplayUpgrades();
        }

        private void InitializeUpgrades()
        {
            upgradesList = new List<Upgrade>
            {
                new ClickUpgrade("Click Upgrade 1", 10),
                new AutoClickUpgrade("AutoClickUpgrade 1", 50)
            };
        }

        private void DisplayUpgrades() 
        {
            foreach (Upgrade upgrade in upgradesList) 
            {
                Button upgradeButton = new Button
                {
                    Content = $"{upgrade.Name} - Cost: {upgrade.Cost}",
                    Tag = upgrade
                };
            }
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Upgrade upgrade)
            {
                if (mainWindow.Score >= upgrade.Cost)
                {
                    mainWindow.Score -= (int)upgrade.Cost;
                    upgrade.Purchase();

                    if (upgrade is ClickUpgrade)
                    {
                        mainWindow.AddClickPower(upgrade.bonusPower);
                    }
                    else if (upgrade is AutoClickUpgrade)
                    {
                        mainWindow.AddAutoClickPower(upgrade.bonusPower);
                    }
                }
                else
                {
                    MessageBox.Show("Now enought money");
                }
            }
        }
    }
}

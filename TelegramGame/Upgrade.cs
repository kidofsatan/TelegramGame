using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramGame
{
    public class Upgrade
    {
        public string Name { get; set; }
        public int Level { get; private set; }
        public double Cost { get; private set; }
        public double BaseCost { get; private set; }
        public int bonusPower;

        public Upgrade(string name, int baseCost)
        {
            Name = name;
            Level = 0;
            BaseCost = baseCost;
            Cost = baseCost;
        }

        public void Purchase()
        {
            Level++;
            Cost = BaseCost * Math.Pow(1.15, Level);
        }
    }

    public class ClickUpgrade : Upgrade
    {
        public ClickUpgrade(string name, int baseCost) : base(name, baseCost) { }
    }

    public class AutoClickUpgrade : Upgrade
    {
        public AutoClickUpgrade(string name, int baseCost) : base(name, baseCost) { }
    }
}

using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Healer : Character, IHeal
    {
        private const int HealerHealthPoints = 75;
        private const int HealerDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerRange = 6;

        public Healer(string id, int x, int y, Team team) : base(id, x, y, HealerHealthPoints, HealerDefensePoints, team, HealerRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override void AddToInventory(Item item)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new System.NotImplementedException();
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            throw new System.NotImplementedException();
        }
    }
}
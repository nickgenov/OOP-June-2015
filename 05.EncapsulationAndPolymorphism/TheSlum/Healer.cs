using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Healer : Character, IHeal
    {
        private const int HealerHealthPoints = 75;
        private const int HealerDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerRange = 6;

        public Healer(string id, int x, int y, Team team) 
            : base(id, x, y, HealerHealthPoints, HealerDefensePoints, team, HealerRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            //TODO Min Health of targets who are not IHeal
            //TODO It only works with one healer per team

            int minHealthPoints = targetsList
                .Where(c => this.Team == c.Team)
                .Where(c => c.IsAlive)
                .Where(c => c is IHeal == false)
                .Min(c => c.HealthPoints);

            //TODO Find a better way to prevent healer to target itself.
            //TODO Currently I use: .Where(c => c is IHeal == false)
            //TODO Again, it only works with one healer per team

            Character targetCharacter = targetsList
                .Where(c => this.Team == c.Team)
                .Where(c => c is IHeal == false)
                .FirstOrDefault(c => c.HealthPoints == minHealthPoints);

            return targetCharacter;
        }

        public override string ToString()
        {
            string result = string.Format("-- {0}, Healing: {1}", base.ToString(), this.HealingPoints);
            return result;
        }
    }
}
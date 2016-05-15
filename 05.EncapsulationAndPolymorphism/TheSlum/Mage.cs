using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Mage : Character, IAttack
    {
        private const int MageHealthPoints = 150;
        private const int MageDefensePoints = 50;
        private const int MageAttackPoints = 300;
        private const int MageRange = 5;

        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, MageHealthPoints, MageDefensePoints, team, MageRange)
        {
            this.AttackPoints = MageAttackPoints;
        }

        public int AttackPoints { get; set; }

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
            Character targetCharacter = targetsList
                .Where(c => this.Team != c.Team)
                .Where(c => c.IsAlive)
                .ToList()
                .LastOrDefault();

            return targetCharacter;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            string result = string.Format("-- {0}, Attack: {1}", base.ToString(), this.AttackPoints);
            return result;
        }
    }
}
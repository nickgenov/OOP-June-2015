using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Mage : Character, IAttack
    {
        private const int MageHealthPoints = 150;
        private const int MageDefensePoints = 50;
        private const int MageAttackPoints = 300;
        private const int MageRange = 5;

        public Mage(string id, int x, int y, Team team) : base(id, x, y, MageHealthPoints, MageDefensePoints, team, MageRange)
        {
            this.AttackPoints = MageAttackPoints;
        }

        public int AttackPoints { get; set; }

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
using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Warrior : Character, IAttack
    {
        private const int WarriorHealthPoints = 200;
        private const int WarriorDefensePoints = 100;
        private const int WarriorAttackPoints = 150;
        private const int WarriorRange = 2;

        public Warrior(string id, int x, int y, Team team) : base(id, x, y, WarriorHealthPoints, WarriorDefensePoints, team, WarriorRange)
        {
            this.AttackPoints = WarriorAttackPoints;
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
namespace TheSlum
{
    public class Pill : Bonus
    {
        private const int PillHealthEffect = 0;
        private const int PillDefenseEffect = 0;
        private const int PillAttackEffect = 100;
        private const int PillDuration = 1;

        public Pill(string id) 
            : base(id, PillHealthEffect, PillDefenseEffect, PillAttackEffect)
        {
            this.Countdown = PillDuration;
        }
    }
}
namespace AcademyRPG
{
    using System.Collections.Generic;

    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;
        private int defensePoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
            //this.DefensePoints = int.MaxValue;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue;
            }

            //private set
            //{
            //    this.defensePoints = value;
            //}
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    if (availableTargets[i].HitPoints > max)
                    {
                        max = availableTargets[i].HitPoints;
                        maxIndex = i;
                    }

                    return maxIndex;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            else if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            return false;
        }
    }
}

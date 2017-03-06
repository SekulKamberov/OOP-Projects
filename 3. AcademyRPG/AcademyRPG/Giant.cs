namespace AcademyRPG
{
    using System.Collections.Generic;

    public class Giant : Character, IFighter, IGatherer
    {
        private int attackPoints;
        private int defensePoints;
        private bool hasGathered;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.AttackPoints = 150;
            this.DefensePoints = 80;
            this.hasGathered = false;
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
                return this.defensePoints;
            }

            private set
            {
                this.defensePoints = value;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.hasGathered)
                {
                    this.AttackPoints += 100;
                    this.hasGathered = true;
                }
                
                return true;
            }

            return false;
        }
    }
}

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private ResourceType resourceType;
        private int quantity;

        public Rock(Point position, int hitPoints)
            : base(position, 0)
        {
            this.HitPoints = hitPoints;
            this.Type = ResourceType.Stone;
            this.Quantity = this.HitPoints / 2;

        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            private set
            {
                this.quantity = value;
            }
        }

        public ResourceType Type
        {
            get
            {
                return this.resourceType;
            }

            private set
            {
                this.resourceType = value;
            }
        }
    }
}

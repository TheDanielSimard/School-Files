namespace Assignment_5_Classes
{
    public class OffCampus : Student
    {
        public OffCampus(int id, string name, int credits, bool hasAuto) : base(id, name, credits)
        {
            this.hasAuto = hasAuto;
        }

        private bool hasAuto;

        protected double AutoCost
        {
            get
            {
                if (!hasAuto)
                {
                    return 0;
                }
                return 500;
            }
        }

        protected override double Calculate()
        {
            return base.CalculateCreditCost() + AutoCost;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Auto Costs: {AutoCost:C}\r\n" +
                $"Total Costs: {Calculate():C}\r\n";
        }
    }
}

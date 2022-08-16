namespace Assignment_5_Classes
{
    public class OnCampus : Student
    {
        public OnCampus(int id, string name, int credits) : base(id, name, credits)
        {

        }

        public Housing Housing { get; set; }

        private double HousingCost
        {
            get
            {
                switch (Housing)
                {
                    case Housing.London:
                        return 5000;

                    case Housing.Paris:
                        return 6000;

                    case Housing.Rome:
                        return 6500;

                    default:
                        return 0;
                }
            }
        }

        protected override double Calculate()
        {
            return base.CalculateCreditCost() + HousingCost;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Housing Costs: {HousingCost:C}\r\n" +
                $"Total Costs: {Calculate():C}\r\n";
        }
    }
}
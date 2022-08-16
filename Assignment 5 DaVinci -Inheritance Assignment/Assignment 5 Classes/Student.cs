namespace Assignment_5_Classes
{
    public abstract class Student
    {
        protected int id;
        protected string name;
        protected int credits;

        protected Student(int id, string name, int credits)
        {
            this.id = id;
            this.name = name;
            this.credits = credits;
        }

        protected double CalculateCreditCost()
        {
            if (credits >= 15)
            {
                return 7500;
            }
            return credits * 500;
        }

        public override string ToString()
        {
            string str = $"ID: {id}\r\n";

            str += $"Name: {name}\r\n";
            str += $"Credit Hours: {credits}\r\n";
            str += $"Credits Cost: {CalculateCreditCost():C}\r\n";

            //Inherited Classes Output The Rest Of ToString()

            return str;
        }

        protected abstract double Calculate();
    }
}
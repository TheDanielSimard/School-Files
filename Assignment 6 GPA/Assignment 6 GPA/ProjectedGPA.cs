using ProjectedGPAInterface;
namespace Assignment_6_GPA
{
    class ProjectedGPA : IProjected
    {
        double points;
        double credits;
        double gpa;
        const double PASSING = 2.0;

        public double Points
        {
            set { points = value; }
        }

        public double Credits
        {
            set { credits = value; }
        }

        //Interface
        public double CalculateGPA()
        {
            double gpa = (points / credits);

            return gpa;
        }

        //Overload Method
        public double CalculateGPA(double points, double credits)
        {
            return gpa = (points / credits);
        }

        //Delegate
        delegate double delgGPA(double x, double y);

        public override string ToString()
        {
            delgGPA results = CalculateGPA;
            return $"GPA using delegate is {results(points, credits)}";
        }

        //Lambda Using Boolean Delegate
        delegate bool GPAGoal(double p);

        public string msg()
        {
            string str = "";
            GPAGoal Goal = ans => gpa >= PASSING;
            str += $"GPA is {gpa}\r\n";
            str += $"Passing is over {PASSING}\r\n";
            str += $"{Goal(gpa)}";
            return str;
        }

        //Delegate & Lambda
        delegate double GPA(double x, double y);

        public string results()
        {
            string str = "";
            GPA i = (double first, double second) => (first / second);
            str += $"GPA is {i(points, credits)}";
            return str;
        }

        //Validate an ID which needs to be 4 characters in length and second character needs to be a 3.
        public string ValidateID(string str)
        {
            int length = str.Length;
            
            string results;

            if (str.Substring(1, 1) == "3" && length == 4)
            {
                results = "Valid";
            }
            else
            {
                results = "Invaild";
            }

            return results;
        }
    }
}

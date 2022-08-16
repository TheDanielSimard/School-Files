//Daniel Simard
//October 20th, 2021
//Assignment 7 - BreakEven
//Calculate Companies Sales and Costs
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7BreakEven
{
    class BreakEven
    {
        //Variables
        string companyName;
        double sellingPrice;
        double overHead;
        double administrativeSalaries;
        double materialCostPercent;
        double laborCostPercent;
        double variablePercent;
        double contributionMargin;
        double fixedCosts;
        double breakEvenUnits;
        double breakEvenSales;
        
        //Properties
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public double SellingPrice
        {
            get { return sellingPrice; }
            set { sellingPrice = value; }
        }
        public double OverHead
        {
            get { return overHead; }
            set { overHead = value; }
        }
        public double AdministrativeSalaries
        {
            get { return administrativeSalaries; }
            set { administrativeSalaries = value; }
        }
        public double MaterialCostPercent
        {
            get { return materialCostPercent; }
            set { materialCostPercent = value; }
        }
        public double LaborCostPercent
        {
            get { return laborCostPercent; }
            set { laborCostPercent = value; }
        }
        public double VariablePercent
        {
            get { return variablePercent; }
            set { variablePercent = value; }
        }
        public double ContributionMargin
        {
            get { return contributionMargin; }
            set { contributionMargin = value; }
        }
        public double FixedCosts
        {
            get { return fixedCosts; }
            set { fixedCosts = value; }
        }
        public double BreakEvenUnits
        {
            get { return breakEvenUnits; }
            set { breakEvenUnits = value; }
        }
        public double BreakEvenSales
        {
            get { return breakEvenSales; }
            set { breakEvenSales = value; }
        }
        //Calculations
        private void BreakEvenCalculations()
        {
            FixedCosts = OverHead + AdministrativeSalaries;
            VariablePercent = MaterialCostPercent + LaborCostPercent;
            ContributionMargin = SellingPrice * VariablePercent;
            BreakEvenUnits = Math.Ceiling(FixedCosts / ContributionMargin * 100); //Converting to percentage
            BreakEvenSales = BreakEvenUnits * SellingPrice;
        }
        //Sends to main
        public override string ToString()
        {
            //Using interpolation operator "$" to embed a value(s) within the string
            BreakEvenCalculations();
            return string.Format("*******************************************************************" +
                $"\n\t{CompanyName}" +
                $"\nTotal fixed costs\t{FixedCosts:C}" +
                $"\nTotal variable percent\t{VariablePercent:F2}%" +
                $"\nBreak even units are\t{BreakEvenUnits}" +
                $"\nBreak even sales are\t{BreakEvenSales:C}");
        }
    }
}
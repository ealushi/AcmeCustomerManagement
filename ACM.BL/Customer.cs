using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {

            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email 
                // using  Regualar Expressions. 
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in a correct format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;
                // Code here that confirms whether the domain exists.
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }
            
            return op;

            // -- Send an email receipt -- 
            // If the user requested a receipt 
            // Get the customer data 
            // Ensure a valid email address was provided. 
            // If not, 
            // request an email address from the user. 
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            // Try 3

            if (string.IsNullOrWhiteSpace(goalSteps))
                throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps))
                throw new ArgumentException("Actual steps must be entered", "actualSteps");

            decimal goalStepCount = 0;
            if (!decimal.TryParse(goalSteps, out goalStepCount))

                throw new ArgumentException("Goal must be numeric", "goalSteps");

            decimal actualStepCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepCount))
                throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount/ goalStepCount)*100, 2);
        }
    }
}

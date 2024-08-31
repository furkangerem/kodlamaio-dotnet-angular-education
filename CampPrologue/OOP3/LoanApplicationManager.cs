using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class LoanApplicationManager
    {
        // Since Interface can hold a reference to all the classes that implement it,
        // if we give the Interface object as the parameter that the method will take, we can send the type of credit we want.
        public void ApplyLoan(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (ILoggerService eachLog in loggerServices)
            {
                eachLog.Log();
            }
        }

        public void ProvideLoanPreInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager eachCredit in credits)
                eachCredit.Calculate();
        }
    }
}

using OOP3;

ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
consumerLoanManager.Calculate();

VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
vehicleLoanManager.Calculate();

MortgageManager mortgageManager = new MortgageManager();
mortgageManager.Calculate();

// They both give the same result.
// Note: Interfaces can also hold the reference number of the class that implements that interface!

ICreditManager clm = new ConsumerLoanManager();
clm.Calculate();

ICreditManager vlm = new VehicleLoanManager();
vlm.Calculate();

ICreditManager mlm = new MortgageManager();
mlm.Calculate();

LoanApplicationManager loanApplicationManager = new LoanApplicationManager();
//loanApplicationManager.ApplyLoan(clm);
//loanApplicationManager.ApplyLoan(vlm);
//loanApplicationManager.ApplyLoan(mlm);

List<ICreditManager> credits = new List<ICreditManager>() { clm, vlm };
loanApplicationManager.ProvideLoanPreInformation(credits);

ILoggerService fileLoggerService = new FileLoggerService();
loanApplicationManager.ApplyLoan(clm, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });
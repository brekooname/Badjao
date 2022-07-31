SELECT StatusOfFunds.BFY, StatusOfFunds.EFY, StatusOfFunds.FundName, StatusOfFunds.FundCode, 
    StatusOfFunds.RpioCode, StatusOfFunds.RpioName, StatusOfFunds.AhName, 
    StatusOfFunds.ProgramProjectName, StatusOfFunds.BocCode, StatusOfFunds.BocName 
Sum(StatusOfFunds.Amount) AS Authority, 
Sum(StatusOfFunds.OpenCommitments) AS OpenCommitments, 
Sum(StatusOfFunds.Obligations) AS Obligations, 
Sum(StatusOfFunds.Used) AS Used, 
ROUND(Sum(StatusOfFunds.Available), 2) AS Available
FROM StatusOfFunds
WHERE StatusOfFunds.BudgetLevel = '7'
GROUP BY StatusOfFunds.BFY, StatusOfFunds.EFY, StatusOfFunds.FundName, StatusOfFunds.FundCode, 
    StatusOfFunds.RpioCode, StatusOfFunds.RpioName, StatusOfFunds.AhName, 
    StatusOfFunds.ProgramProjectName, StatusOfFunds.BocCode, StatusOfFunds.BocName 
ORDER BY StatusOfFunds.BFY DESC , StatusOfFunds.FundCode;


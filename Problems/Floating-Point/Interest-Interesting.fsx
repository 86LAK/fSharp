module InterestIsInteresting


let interestRate (balance: decimal): single =
  match balance with 
  | b when b < 0.0m -> 3.213f
  | b when b < 1000.0m -> 0.5f
  | b when b < 5000.0m -> 1.621f
  | _ -> 2.475f

let interest (balance: decimal): decimal =
  balance * decimal (interestRate balance) / decimal 100 

let annualBalanceUpdate(balance: decimal): decimal =
  balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if balance < 0.0m then 
       0
    else
        balance * decimal (taxFreePercentage / 100.0 * 2.0) |> int

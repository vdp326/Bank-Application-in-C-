﻿using SGBank.Models;
using SGBank.Models.Responses;
using System;
using SGBank.Models.Interfaces;

namespace SGBank.BLL.DepositRules
{
    public class FreeAccountDepositRule : IDeposit
    {
        public AccountDepositResponse Deposit(AccountManager account, decimal amount)
        {
            AccountDepositResponse response = new AccountDepositResponse();

            if(account.Type != AccountType.Free)
            {
                response.Success = false;
                response.Message = "Error: a non free account hit the Free Deposit Rule. Contact IT";
                return response;
            }

            if(amount > 100)
            {
                response.Success = false;
                response.Message = "Free accounts cannot deposit more than 100 at a time";
                return response;
            }

            if(amount <= 0)
            {
                response.Success = false;
                response.Message = "Deposit amounts must be greater than zero.";
                return response;
            }

            response.OldBalance = account.Balance;
            account.Balance += amount;
            response.Account = account.Type;
            response.Amount = amount;
            response.Success = true;

            return response;

        }

        AccountDepositResponse IDeposit.Deposit(Account account, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}

using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{

    public class BankAccountTests
    {
        private BankAccount account;
        private decimal balance;


        public BankAccountTests()
        {
            account= new BankAccount();
            balance = account.GetBalance();

        }

        [Fact]
        public void NewAccountsHaveCorrectBalance()
        {
      

            Assert.Equal(5000M, balance);
        
        }

        public void DepositsIncreaseTheBalance()
        {
            //Given
            var amountToDeposit = 42M;

            //When
            account.Deposit(amountToDeposit);

            //Then 
            Assert.Equal(balance + amountToDeposit, account.GetBalance());            
        
        }

        [Fact]
        public void WithdrawalsDecreaseTheBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 42M;

            account.Withdraw(amountToWithdraw);

            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }

    }
}

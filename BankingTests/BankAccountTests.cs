﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{

    public class BankAccountTests
    {
        [Fact]
        public void NewAccountsHaveCorrectBalance()
        {
            var account = new BankAccount();

            decimal balance = account.GetBalance();

            Assert.Equal(5000M, balance);
        
        }

    }
}
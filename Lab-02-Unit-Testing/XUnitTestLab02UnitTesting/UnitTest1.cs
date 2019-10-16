using System;
using Xunit;
using static Lab_02_Unit_Testing.Program;

namespace XUnitTestLab02UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestingAdd()
        {
            Assert.Equal(10000, Deposit(9500, 500));
        }

        [Fact]
        public void TestingNotEqualingWhenAdding()
        {
            Assert.NotEqual(10600, Deposit(9500, 500));
        }

        [Theory]
        [InlineData(5000, 500)]
        [InlineData(9000, 600)]
        [InlineData(4900, 500)]
        [InlineData(9878, 10.23)]
        public void WithdrawingFromBalance(double balance, double withdrawAmount)
        {
            double newBalance = balance - withdrawAmount;
            Assert.Equal(newBalance, WithDraw(balance, withdrawAmount));
        }
    }
}

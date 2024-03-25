namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deposit_IncreasesBalance()
        {
            // Arrange
            var account = new EverydayAccount();
            decimal initialBalance = account.Balance;
            decimal depositAmount = 100;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(initialBalance + depositAmount, account.Balance);
        }
        [Test]
        public void Withdraw_WithValidAmount_ReturnsTrue()
        {
            // Arrange
            var account = new InvestmentAccount();
            decimal initialBalance = 1000;
            account.Deposit(initialBalance);
            decimal withdrawalAmount = 500;

            // Act
            bool result = account.Withdraw(withdrawalAmount);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance - withdrawalAmount, account.Balance);
        }


    }
}
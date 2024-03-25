using myBank;
using NUnit.Framework;

namespace AccountTesting
{
    public class EverydayAccountTests
    {
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
            Assert.That(account.Balance, Is.EqualTo(initialBalance + depositAmount));
        }

        [Test]
        public void Withdraw_WithValidAmount_ReturnsTrue()
        {
            // Arrange
            var account = new EverydayAccount();
            decimal initialBalance = 1000;
            account.Deposit(initialBalance);
            decimal withdrawalAmount = 500;

            // Act
            bool result = account.Withdraw(withdrawalAmount);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(account.Balance, Is.EqualTo(initialBalance - withdrawalAmount));
        }

        [Test]
        public void Withdraw_WithInsufficientFunds_ReturnsFalse()
        {
            // Arrange
            var account = new EverydayAccount();
            decimal initialBalance = 100;
            account.Deposit(initialBalance);
            decimal withdrawalAmount = 500;

            // Act
            bool result = account.Withdraw(withdrawalAmount);

            // Assert
            Assert.That(result, Is.False);
            Assert.That(account.Balance, Is.EqualTo(initialBalance));
        }
            [Test]
            public void Withdraw_WithNegativeAmount_ThrowsArgumentException()
            {
                // Arrange
                var account = new EverydayAccount();
                decimal initialBalance = 1000;
                account.Deposit(initialBalance);
                decimal withdrawalAmount = -100;

                // Act and Assert
                Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawalAmount));
            }
        }
    } 
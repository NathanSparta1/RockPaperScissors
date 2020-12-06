using NUnit.Framework;
using Rock_Paper_Scissors;

namespace NUnitTestRPS
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestUserInput()
        {
           
            string test1 = "rock";
            string test2 = "paper";
            string test3 = "scissors";
            string test4 = "gun";


            Assert.AreEqual("rock", WeaponConfig.UserWeaponSelect(test1));
            Assert.AreEqual("paper", WeaponConfig.UserWeaponSelect(test2));
            Assert.AreEqual("scissors", WeaponConfig.UserWeaponSelect(test3));

            Assert.AreNotEqual("gun", WeaponConfig.UserWeaponSelect(test4));
        }

    }
}
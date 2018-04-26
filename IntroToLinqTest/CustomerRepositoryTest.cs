using IntroToLinq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntroToLinqTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindExistingCustomer()
        {
            //Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.RetrieveCustomer();

            //Act
            var result = repository.FindCustomer(customerList, 1);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CustomerId);

        }
    }
}

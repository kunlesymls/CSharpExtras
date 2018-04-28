using IntroToLinq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        [TestMethod]
        public void SortByLastName()
        {
            //Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.RetrieveCustomer();

            //Act
            var result = repository.SortByLastName(customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Ala", result.First().LastName);

        }
    }
}

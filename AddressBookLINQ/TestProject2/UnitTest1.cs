using NUnit.Framework;

namespace AddressBookLINQ
{
    public class Tests
    {
        AddressBook address = new AddressBook();

        [SetUp]
        public void Setup()
        {
            address = new AddressBook();
        }

        [Test]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = address.AddValues();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 0;
            int actual = address.EditDataTable("Sej", "Firstname");
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = address.DeleteRowInDataTable("lalita");
            Assert.AreEqual(actual, expected);
        }
    }
}
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
            int actual = address.DeleteRowInDataTable("lalit");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRetrieveTheDataByCity_State()
        {
            string expected = "Sunny Sejwar ";
            string actual = address.RetrieveBasedOnCityorState("Gwa", "MP");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenSortedData_Alphabetically()
        {
            string expected = "Sunny ";
            string actual = address.SortBasedOnNameInDataTable("Gwalior");
            Assert.AreEqual(expected, actual);
        }
    }
}
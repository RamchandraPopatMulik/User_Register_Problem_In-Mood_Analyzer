using User_Registration_MoodAnalyzer;
namespace First_Number
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = new User();
            bool result = user.FirstName("Ramchandra");
            Assert.IsTrue(result);  
        }
    }
}
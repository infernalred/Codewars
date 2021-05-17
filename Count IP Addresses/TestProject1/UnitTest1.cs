using Count_IP_Addresses;
using NUnit.Framework;

namespace TestProject1
{
    public class CountIPAddressesTest
    {
        [Test]
        public void SmapleTest1()
        {
            Assert.AreEqual(50, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
        }
        
        [Test]
        public void SmapleTest2()
        {
            Assert.AreEqual(246, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
        }
    }
}
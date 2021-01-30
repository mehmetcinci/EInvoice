using System;
using Xunit;

namespace EInvoice.Xsd.NewUserList.XUnitTest {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            Utilities.ZipClass.UnZip();
            string fileNameXml = "newUserPkList.xml";
            UserList.LoadFromFile(fileNameXml, out UserList userList, out Exception exception);
            if (exception == null) {
                if (userList.User.Count == 335553)
                    Assert.True(true);
                else
                    Assert.False(true);
            }
            else {
                Assert.False(true, $"Exception: {exception.Message}");
            }
        }
    }
}
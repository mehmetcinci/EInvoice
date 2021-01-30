using System.IO;
using System.IO.Compression;
using System.Linq;

namespace EInvoice.Xsd.NewUserList.XUnitTest.Utilities {
    public class ZipClass {
        public static void UnZip() {
            string startPath = Directory.GetCurrentDirectory();
            string zipPath = @"newUserPkList.zip";
            ZipFile.ExtractToDirectory(zipPath, startPath, true);
        }
    }
}
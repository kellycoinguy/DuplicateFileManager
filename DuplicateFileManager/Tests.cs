using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DuplicateFileManager
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void TestFrameworkIsWorking()
        {
            Assert.That(true, Is.True);
        }

        [Test]
        public void DriveHasLetter()
        {
            Drive f = new Drive('F');
            Assert.That(f.DriveLetter == 'F');
        }
    }
}

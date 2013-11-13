using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuplicateFileManager
{
    public class Drive
    {
        private char _driveLetter;
        public Drive(char driveLetter)
        {
            _driveLetter = driveLetter;
        }

        public char DriveLetter { get { return _driveLetter; } }
    }
}

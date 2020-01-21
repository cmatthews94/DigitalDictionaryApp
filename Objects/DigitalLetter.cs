using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDictionaryApp.Objects
{
    public class DigitalLetter
    {
        //class was unneccessary in the end. Lesson learned to not always default to creating objects where simpler structure is suffucient.

        public bool TopSegmentExists { get; set; }
        public bool TopLeftSegmentExists { get; set; }
        public bool TopRightSegmentExists { get; set; }
        public bool CenterSegmentExists { get; set; }
        public bool BottomLeftSegmentExists { get; set; }
        public bool BottomRightSegmentExists { get; set; }
        public bool BottomSegmentExists { get; set; }

    }
}

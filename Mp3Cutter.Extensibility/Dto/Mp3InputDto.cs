using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3Cutter.Extensibility.Dto
{
    public class Mp3InputDto
    {
        public int BeginCut { get; set; }

        public int EndCut { get; set; }

        public string Mp3Path { get; set; }
    }
}
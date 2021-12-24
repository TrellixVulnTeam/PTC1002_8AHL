using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTC1002.Dtos
{
    public class ReportRandomNumberDto
    {
        public int Numeric { get; set; }
        public string AlphaNumeric { get; set; }
        public float Float { get; set; }
        public float NumericPerct { get; set; }
        public float AlphaNumericPerct { get; set; }
        public float FloatPerct { get; set; }

    }
}

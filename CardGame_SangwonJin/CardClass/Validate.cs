using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Validate
    {
        private Validate()
        {
        }

        public static bool ValidatePositive(float value)
        {
            if (value >= 0)
                return true;
            return false;
        }

        public static bool ValidNotEmpty(string value)
        {
            if (value != string.Empty)
                return true;
            return false;
        }

        public static bool ValidWithinRange(string value, float min, float max)
        {
            if (IsNumeric(value) && System.Convert.ToSingle(value) >= min && System.Convert.ToSingle(value) <= max)
                return true;
            return false;
        }

        public static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}

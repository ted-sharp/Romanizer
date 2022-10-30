using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Romanizer
{
    internal class ToUpperCase : ICulturedStringTransformer
    {
        public string Transform(string input)
        {
            return Transform(input, CultureInfo.CurrentCulture);
        }

        public string Transform(string input, CultureInfo culture)
        {
            return culture.TextInfo.ToUpper(input);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Romanizer
{
    /// <summary>
    /// Can transform a string with the given culture
    /// </summary>
    public interface ICulturedStringTransformer : IStringTransformer
    {
        /// <summary>
        /// Transform the input
        /// </summary>
        /// <param name="input">String to be transformed</param>
        /// <param name="culture">The culture</param>
        string Transform(string input, CultureInfo culture);
    }
}

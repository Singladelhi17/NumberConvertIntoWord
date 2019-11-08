using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertNumericValueIntoWords.Repository
{
    public interface INumberConverter
    {
        string NumberConvertToWords(String numb);
    }
}
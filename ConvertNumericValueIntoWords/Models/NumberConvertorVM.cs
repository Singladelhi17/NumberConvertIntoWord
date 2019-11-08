using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConvertNumericValueIntoWords.Models
{
    public class NumberConvertorVM
    {
        [Display(Name = "Name")]
        [Required]
        public string PersonName
        {
            get;
            set;
        }
        [Display(Name = "Number")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "Number must be a positive number")]
        [Required]
        public decimal Number
        {
            get;
            set;
        }
        [Display(Name = "Number(as Word)")]
        public string NumberInWord
        {
            get;
            set;
        }
    }
}
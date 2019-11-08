using ConvertNumericValueIntoWords.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConvertNumericValueIntoWords.API
{
    public class NumberConverterApiController : ApiController
    {
        private readonly INumberConverter _numberConverter;
        public NumberConverterApiController(INumberConverter numberConverter)
        {
            _numberConverter = numberConverter;
        }
        [HttpGet]
        public IHttpActionResult NumberConvertIntoWord(string number)
        {
            var word = _numberConverter.NumberConvertToWords(number);
            if (word == null)
            {
                return NotFound();
            }

            return Ok(word);
        }
    }
}

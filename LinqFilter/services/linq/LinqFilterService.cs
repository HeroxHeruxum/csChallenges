using LinqFilter.services.parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFilter.services.linq
{
    public class LinqFilterService(IArrayParserService arrayParser) : ILinqFilterService
    {
        public List<int> FilterEvenNumbers(string input)
        {
            var numbers = arrayParser.ParseToIntArray(input);
            return FilterEvenNumbers(numbers);
        }

        public List<int> FilterEvenNumbers(List<int> numbers)
        {
            IEnumerable<int> evenNumbers = from number in numbers
                                           where number % 2 == 0 
                                           select number;
            return evenNumbers.ToList();
        }
    }
}

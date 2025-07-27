using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFilter.services.parsing
{
    public class ArrayParserService : IArrayParserService
    {
        public List<int> ParseToIntArray(string input)
        {
            return input.Split(',')
                        .Select(x => x.Trim())
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Where(x => int.TryParse(x, out _))
                        .Select(int.Parse)
                        .ToList();
        }
    }
}

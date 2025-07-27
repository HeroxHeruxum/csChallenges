using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFilter.services.parsing
{

    public interface IArrayParserService
    {
        public List<int> ParseToIntArray(string input);
    }
}

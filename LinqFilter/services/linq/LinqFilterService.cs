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
    }
}

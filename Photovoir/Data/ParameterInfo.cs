using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Data
{
    public class ParameterInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
        public object DefaultValue { get; set; }
    }
}

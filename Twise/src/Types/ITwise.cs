using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twise.src.Types
{
  interface ITwise
  {
    Guid Guid { get; set; }
    string Description { get; set; }
    IEnumerable<ITwiseMap> ObjectMaps {get; set;}
}
}

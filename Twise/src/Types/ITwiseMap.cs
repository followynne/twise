using System.Collections.Generic;

namespace Twise.src.Types
{
  interface ITwiseMap
  {
    string ObjectPropertyName { get; set; }
    IEnumerable<ITwiseProperty> DynamicTraversingMap { get; set; }
    bool HasNext();
    ITwiseProperty Next();
    ITwiseProperty Prev();
  }
}

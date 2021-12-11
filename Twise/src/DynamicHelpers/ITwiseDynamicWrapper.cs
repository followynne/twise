using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twise.src.DynamicHelpers
{
#nullable enable
  interface ITwiseDynamicWrapper
  {
    T ConvertProp<T>(dynamic propertyToConvert);
    bool DoPropExist(string propertyName);
    T GetProp<T>(string propertyName);
    bool TryConvertProp<T>(dynamic propertyToConvert, out T safelyConvertedProp);
    bool TryGetProp<T>(string propertyName, out T property);
  }
}

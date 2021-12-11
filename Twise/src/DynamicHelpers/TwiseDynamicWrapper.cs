using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twise.src.DynamicHelpers
{
  internal class TwiseDynamicWrapper : ITwiseDynamicWrapper
  {
    public TwiseDynamicWrapper(dynamic dynamicObject)
    {
      DynamicObject = dynamicObject;
    }
    public dynamic DynamicObject { get; set; }

    public T ConvertProp<T>(dynamic propertyToConvert)
    {
      throw new NotImplementedException();
    }

    public bool DoPropExist(string propertyName)
    {
      throw new NotImplementedException();
    }

    public T GetProp<T>(string propertyName)
    {
      throw new NotImplementedException();
    }

    public bool TryConvertProp<T>(dynamic propertyToConvert, out T safelyConvertedProp)
    {
      throw new NotImplementedException();
    }

    public bool TryGetProp<T>(string propertyName, out T property)
    {
      throw new NotImplementedException();
    }
  }
}

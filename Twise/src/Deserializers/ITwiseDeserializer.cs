using System;
using System.Collections.Generic;
using Twise.src.Converters;
using Twise.src.Types;

namespace Twise.src.Deserializers
{
  interface ITwiseDeserializer
  {
    IEnumerable<ITwiseProperty> TwiseValues { get; set; }

    ITwiseTypeConverter GetConverter(Type twiseType);
    // on each iteration, dynamic property will be checked for existence
    // it will receive next twiseProperty, which will inform how the item should be casted
    // at the end, it will receive T
    // if the expected T isn't the one out of convert, throw
    T SafeConvert<T>(dynamic currentItemContentIteration); // move in ITwiseTypeConverter


  }
}

using System;

namespace Twise.src.Types
{
    interface ITwiseProperty
    {
        Type ExpectedType { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}

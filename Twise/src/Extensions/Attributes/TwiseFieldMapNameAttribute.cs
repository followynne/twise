using System;

namespace Twise.src.Extensions.Attributes
{
  [AttributeUsage(AttributeTargets.Field)]
  public sealed class TwiseFieldMapNameAttribute : Attribute
  {
    private readonly string _mapName;
    public TwiseFieldMapNameAttribute(string mapName)
    {
      _mapName = mapName;
    }
    public string MapName { get => _mapName; }
  }
}

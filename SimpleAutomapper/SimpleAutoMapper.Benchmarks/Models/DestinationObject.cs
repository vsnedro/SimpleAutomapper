using System;

namespace SimpleAutoMapper.Benchmarks.Models;

internal class DestinationObject : BaseObject
{
    public Guid CustomGuidField;
    public Guid CustomGuidProperty { get; set; }

    public int CustomIntField;
    public int CustomIntProperty { get; set; }

    public double CustomDoubleField;
    public double CustomDoubleProperty { get; set; }

    public string CustomStringField;
    public string CustomStringProperty { get; set; }

    public DateTime CustomDateTimeField;
    public DateTime CustomDateTimeProperty { get; set; }
}

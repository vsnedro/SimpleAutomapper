using System;

namespace SimpleAutoMapper.Benchmarks.Models;

internal class SourceObject : BaseObject
{
    public new readonly Guid GuidField1 = Guid.NewGuid();
    public new readonly Guid GuidField2 = Guid.NewGuid();
    public new readonly Guid GuidField3 = Guid.NewGuid();

    public override Guid GuidProperty1 => Guid.NewGuid();
    public override Guid GuidProperty2 => Guid.NewGuid();
    public override Guid GuidProperty3 => Guid.NewGuid();

    public new readonly int IntField1 = 1001;
    public new readonly int IntField2 = 1002;
    public new readonly int IntField3 = 1003;

    public override int IntProperty1 => 1004;
    public override int IntProperty2 => 1005;
    public override int IntProperty3 => 1006;

    public new readonly double DoubleField1 = 1001.1001d;
    public new readonly double DoubleField2 = 1002.1002d;
    public new readonly double DoubleField3 = 1003.1003d;

    public override double DoubleProperty1 => 1004.1004d;
    public override double DoubleProperty2 => 1005.1005d;
    public override double DoubleProperty3 => 1006.1006d;

    public new readonly string StringField1 = Guid.NewGuid().ToString();
    public new readonly string StringField2 = Guid.NewGuid().ToString();
    public new readonly string StringField3 = Guid.NewGuid().ToString();

    public override string StringProperty1 => Guid.NewGuid().ToString();
    public override string StringProperty2 => Guid.NewGuid().ToString();
    public override string StringProperty3 => Guid.NewGuid().ToString();

    public new readonly DateTime DateTimeField1 = DateTime.Parse("01/01/2001 01:01:01");
    public new readonly DateTime DateTimeField2 = DateTime.Parse("02/02/2002 02:02:02");
    public new readonly DateTime DateTimeField3 = DateTime.Parse("03/03/2003 03:03:03");

    public override DateTime DateTimeProperty1 => DateTime.Parse("04/04/2004 04:04:04");
    public override DateTime DateTimeProperty2 => DateTime.Parse("05/05/2005 05:05:05");
    public override DateTime DateTimeProperty3 => DateTime.Parse("06/06/2006 06:06:06");

    public new readonly Numbers EnumField1 = Numbers.One;
    public new readonly Numbers EnumField2 = Numbers.Two;
    public new readonly Numbers EnumField3 = Numbers.One;

    public override Numbers EnumProperty1 => Numbers.Four;
    public override Numbers EnumProperty2 => Numbers.Five;
    public override Numbers EnumProperty3 => Numbers.Six;

    public new readonly Guid SomeGuidField = Guid.NewGuid();
    public Guid SomeGuidProperty => Guid.NewGuid();

    public new readonly int SomeIntField = 1011;
    public int SomeIntProperty => 1012;

    public new readonly double SomeDoubleField = 1011.1011d;
    public double SomeDoubleProperty => 1012.1012d;

    public new readonly string SomeStringField = Guid.NewGuid().ToString();
    public string SomeStringProperty => Guid.NewGuid().ToString();

    public new readonly DateTime SomeDateTimeField = DateTime.Parse("11/11/2011 11:11:11");
    public DateTime SomeDateTimeProperty => DateTime.Parse("12/12/2012 12:12:12");
}

using System;

namespace SimpleAutoMapper.Tests.Models;

internal class TestSource : BaseTestObject
{
    public new readonly Guid GuidField1 = Guid.Parse("{6579F6F6-570F-4507-8DB6-59BFFE77A1EF}");
    public new readonly Guid GuidField2 = Guid.Parse("{D990B109-C51F-4D07-B33D-67234D3CFC79}");
    public new readonly Guid GuidField3 = Guid.Parse("{9ED80393-9CDE-41C5-8D3A-F6C2CBE94E7F}");

    public new Guid GuidProperty1 => Guid.Parse("{ED6F36F4-3A91-4E3F-B346-D460139BEB57}");
    public new Guid GuidProperty2 => Guid.Parse("{795CC5DC-8FFC-41B7-A1D6-73CA7AA73B82}");
    public new Guid GuidProperty3 => Guid.Parse("{216CDD82-0D1F-40B3-8B5D-C3C84FFF7CBC}");

    public new readonly int IntField1 = 1001;
    public new readonly int IntField2 = 1002;
    public new readonly int IntField3 = 1003;

    public new int IntProperty1 => 1004;
    public new int IntProperty2 => 1005;
    public new int IntProperty3 => 1006;

    public new readonly double DoubleField1 = 1001.1001d;
    public new readonly double DoubleField2 = 1002.1002d;
    public new readonly double DoubleField3 = 1003.1003d;

    public new double DoubleProperty1 => 1004.1004d;
    public new double DoubleProperty2 => 1005.1005d;
    public new double DoubleProperty3 => 1006.1006d;

    public new readonly string StringField1 = "StringProperty1";
    public new readonly string StringField2 = "StringProperty2";
    public new readonly string StringField3 = "StringProperty3";

    public new string StringProperty1 => "StringField1";
    public new string StringProperty2 => "StringField2";
    public new string StringProperty3 => "StringField3";

    public new readonly DateTime DateTimeField1 = DateTime.Parse("01/01/2001 01:01:01");
    public new readonly DateTime DateTimeField2 = DateTime.Parse("02/02/2002 02:02:02");
    public new readonly DateTime DateTimeField3 = DateTime.Parse("03/03/2003 03:03:03");

    public new DateTime DateTimeProperty1 => DateTime.Parse("04/04/2004 04:04:04");
    public new DateTime DateTimeProperty2 => DateTime.Parse("05/05/2005 05:05:05");
    public new DateTime DateTimeProperty3 => DateTime.Parse("06/06/2006 06:06:06");

    public new readonly Eumbers EnumField1 = Eumbers.One;
    public new readonly Eumbers EnumField2 = Eumbers.Two;
    public new readonly Eumbers EnumField3 = Eumbers.One;

    public new Eumbers EnumProperty1 => Eumbers.Four;
    public new Eumbers EnumProperty2 => Eumbers.Five;
    public new Eumbers EnumProperty3 => Eumbers.Six;

    public new readonly object ObjectField1 = new();
    public new readonly object ObjectField2 = new();
    public new readonly object ObjectField3 = new();

    public new object ObjectProperty1 => ObjectField1;
    public new object ObjectProperty2 => ObjectField2;
    public new object ObjectProperty3 => ObjectField3;

    public readonly Guid SomeGuidField = Guid.Parse("{F2FE24E0-C002-4C89-AB0F-68C773071BD1}");
    public Guid SomeGuidProperty => Guid.Parse("{3A49DAA2-8AD8-42E7-B0C6-F34D2983A2D5}");

    public readonly int SomeIntField = 1011;
    public int SomeIntProperty => 1012;

    public readonly double SomeDoubleField = 1011.1011d;
    public double SomeDoubleProperty => 1012.1012d;

    public readonly string SomeStringField = "SourceStringField";
    public string SomeStringProperty => "SourceStringProperty";

    public readonly DateTime SomeDateTimeField = DateTime.Parse("11/11/2011 11:11:11");
    public DateTime SomeDateTimeProperty => DateTime.Parse("12/12/2012 12:12:12");
}

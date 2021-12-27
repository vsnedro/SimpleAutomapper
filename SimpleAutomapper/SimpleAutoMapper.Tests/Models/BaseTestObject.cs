using System;

namespace SimpleAutoMapper.Tests.Models;

internal class BaseTestObject
{
    public Guid GuidField1;
    public Guid GuidField2;
    public Guid GuidField3;

    public virtual Guid GuidProperty1 { get; set; }
    public virtual Guid GuidProperty2 { get; set; }
    public virtual Guid GuidProperty3 { get; set; }

    public int IntField1;
    public int IntField2;
    public int IntField3;

    public virtual int IntProperty1 { get; set; }
    public virtual int IntProperty2 { get; set; }
    public virtual int IntProperty3 { get; set; }

    public double DoubleField1;
    public double DoubleField2;
    public double DoubleField3;

    public virtual double DoubleProperty1 { get; set; }
    public virtual double DoubleProperty2 { get; set; }
    public virtual double DoubleProperty3 { get; set; }

    public string StringField1;
    public string StringField2;
    public string StringField3;

    public virtual string StringProperty1 { get; set; }
    public virtual string StringProperty2 { get; set; }
    public virtual string StringProperty3 { get; set; }

    public DateTime DateTimeField1;
    public DateTime DateTimeField2;
    public DateTime DateTimeField3;

    public virtual DateTime DateTimeProperty1 { get; set; }
    public virtual DateTime DateTimeProperty2 { get; set; }
    public virtual DateTime DateTimeProperty3 { get; set; }

    public Eumbers EnumField1;
    public Eumbers EnumField2;
    public Eumbers EnumField3;

    public virtual Eumbers EnumProperty1 { get; set; }
    public virtual Eumbers EnumProperty2 { get; set; }
    public virtual Eumbers EnumProperty3 { get; set; }

    public object ObjectField1;
    public object ObjectField2;
    public object ObjectField3;

    public virtual object ObjectProperty1 { get; set; }
    public virtual object ObjectProperty2 { get; set; }
    public virtual object ObjectProperty3 { get; set; }
}

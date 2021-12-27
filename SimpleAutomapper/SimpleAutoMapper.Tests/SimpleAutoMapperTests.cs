using System;

using NUnit.Framework;

using SimpleAutoMapper.Tests.Models;

namespace SimpleAutoMapper.Tests;

public class SimpleAutoMapperTests
{
    private SimpleMapper<TestSource, TestDestination> _mapper;

    [SetUp]
    public void Setup()
    {
        _mapper = new SimpleMapper<TestSource, TestDestination>();
    }

    [Test]
    public void Map_GuidFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.GuidField1, destination.GuidField1);
        Assert.AreEqual(source.GuidField2, destination.GuidField2);
        Assert.AreEqual(source.GuidField3, destination.GuidField3);
    }

    [Test]
    public void Map_GuidPropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.GuidProperty1, destination.GuidProperty1);
        Assert.AreEqual(source.GuidProperty2, destination.GuidProperty2);
        Assert.AreEqual(source.GuidProperty3, destination.GuidProperty3);
    }

    [Test]
    public void Map_IntFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.IntField1, destination.IntField1);
        Assert.AreEqual(source.IntField2, destination.IntField2);
        Assert.AreEqual(source.IntField3, destination.IntField3);
    }

    [Test]
    public void Map_IntPropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.IntProperty1, destination.IntProperty1);
        Assert.AreEqual(source.IntProperty2, destination.IntProperty2);
        Assert.AreEqual(source.IntProperty3, destination.IntProperty3);
    }

    [Test]
    public void Map_DoubleFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.DoubleField1, destination.DoubleField1);
        Assert.AreEqual(source.DoubleField2, destination.DoubleField2);
        Assert.AreEqual(source.DoubleField3, destination.DoubleField3);
    }

    [Test]
    public void Map_DoublePropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.DoubleProperty1, destination.DoubleProperty1);
        Assert.AreEqual(source.DoubleProperty2, destination.DoubleProperty2);
        Assert.AreEqual(source.DoubleProperty3, destination.DoubleProperty3);
    }

    [Test]
    public void Map_StringFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.StringField1, destination.StringField1);
        Assert.AreEqual(source.StringField2, destination.StringField2);
        Assert.AreEqual(source.StringField3, destination.StringField3);
    }

    [Test]
    public void Map_StringPropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.StringProperty1, destination.StringProperty1);
        Assert.AreEqual(source.StringProperty2, destination.StringProperty2);
        Assert.AreEqual(source.StringProperty3, destination.StringProperty3);
    }

    [Test]
    public void Map_DateTimeFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.DateTimeField1, destination.DateTimeField1);
        Assert.AreEqual(source.DateTimeField2, destination.DateTimeField2);
        Assert.AreEqual(source.DateTimeField3, destination.DateTimeField3);
    }

    [Test]
    public void Map_DateTimePropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.DateTimeProperty1, destination.DateTimeProperty1);
        Assert.AreEqual(source.DateTimeProperty2, destination.DateTimeProperty2);
        Assert.AreEqual(source.DateTimeProperty3, destination.DateTimeProperty3);
    }

    [Test]
    public void Map_EnumFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.EnumField1, destination.EnumField1);
        Assert.AreEqual(source.EnumField2, destination.EnumField2);
        Assert.AreEqual(source.EnumField3, destination.EnumField3);
    }

    [Test]
    public void Map_EnumPropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(source.EnumProperty1, destination.EnumProperty1);
        Assert.AreEqual(source.EnumProperty2, destination.EnumProperty2);
        Assert.AreEqual(source.EnumProperty3, destination.EnumProperty3);
    }

    [Test]
    public void Map_ObjectFieldAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreSame(source.ObjectField1, destination.ObjectField1);
        Assert.AreSame(source.ObjectField2, destination.ObjectField2);
        Assert.AreSame(source.ObjectField3, destination.ObjectField3);
    }

    [Test]
    public void Map_ObjectPropertiesAreEqual()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreSame(source.ObjectProperty1, destination.ObjectProperty1);
        Assert.AreSame(source.ObjectProperty2, destination.ObjectProperty2);
        Assert.AreSame(source.ObjectProperty3, destination.ObjectProperty3);
    }

    [Test]
    public void Map_CustomFieldAreDefault()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(default(Guid), destination.CustomGuidField);
        Assert.AreEqual(default(int), destination.CustomIntField);
        Assert.AreEqual(default(double), destination.CustomDoubleField);
        Assert.AreEqual(default(string), destination.CustomStringField);
        Assert.AreEqual(default(DateTime), destination.CustomDateTimeField);
    }

    [Test]
    public void Map_CustomPropertiesAreDefault()
    {
        var source = new TestSource();

        var destination = _mapper.Map(source);

        Assert.AreEqual(default(Guid), destination.CustomGuidProperty);
        Assert.AreEqual(default(int), destination.CustomIntProperty);
        Assert.AreEqual(default(double), destination.CustomDoubleProperty);
        Assert.AreEqual(default(string), destination.CustomStringProperty);
        Assert.AreEqual(default(DateTime), destination.CustomDateTimeProperty);
    }
}

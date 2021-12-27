# SimpleAutomapper
Simple automapper

SimpleAutomapper is a small simple library for automatically mapping one object to another.

Example:
var mapper = new SimpleMapper<SourceType, DestinationType>();
var sourceObject = new SourceType();
var destinationObject = mapper.Map(sourceObject);

# razorweather

A simple web based weather app with razor front end to be used as boiler plate for layered architecture with service, data and web / front end layer with dependency injection using Autofac. 
Weather data is provided as in-memory implementation.

Structure of solution
	1. UI Layer - WeatherApp.Web
	2. Service Layer - WeatherApp.services
	3. Data Access Layer - WeatherApp.Data
Test
	4. WeatherApp.Tests

Front End: Razor,JQuery, Bootstrap
Dependency Injection: Autofac is the IOC tool used for dependency injection
Unit Testing: NUnit

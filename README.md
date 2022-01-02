# csharp_xunit
 Unit Testing with xUnit.net
 

Asserts

Asserts evaluate and verify the outcome of a test, based on a returned result, final object state, or the occurrence of events observed during execution. An assert can either pass or fail. If all asserts pass, the test passes; if any assert fails the test fails. xUnit.Net provides a wide range of assert functionality for different types of results.


Asserting Boolean Values:
Assert.True(sut.IsNoob); 

Asserting on Numeric Values
Assert.Equal(3.14, PI);
Assert.NotEqual(3.14, PI);
Assert.InRange(sut.Health, 101, 200); 

Making Assertions Against String Values
Assert.Equal("Sarah Smith", sut.FullName);
Assert.Equal("Sarah Smith", sut.FullName, ignoreCase: true);
Assert.StartsWith("Sarah", sut.FullName); 
Assert.EndsWith("Smith", sut.FullName);
Assert.Contains("Long Bow", sut.Weapons); 
Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);

Asserting Null Values
Assert.Null(sut.Nickname); 

Making Asserts Against Object Types
Assert.IsType(enemy); 
Assert.IsNotType(enemy); 

 
Asserting on Object Instances
We can also write tests to check that two object references are equal that is they point to the same object. To do so,
Assert.Same(enemy1, enemy2); 
Assert.NotSame(enemy1, enemy2); 

Asserting That Code Throws the Correct Exceptions
During test execution, if an exception is thrown, then the test will automatically fail. But sometimes we want to check that our code is actually throwing exceptions at the correct times. 
Assert.Throws(() => sut.Create(null)); 

Asserting That Events Are Raised
In addition to Asserting that during execution an exception should be thrown, we can also assert that events are raised.
Assert.Raises(…)
 

# Unit Tests
This project is an example how to use xUnit.NET to test your code

### Asserts
Asserts evaluate and verify the outcome of a test, based on a returned result, final object state, or the occurrence of events observed during execution. An assert can either pass or fail. If all asserts pass, the test passes; if any assert fails the test fails. xUnit.Net provides a wide range of assert functionality for different types of results.


<b>Asserting Boolean Values:</b><br>
Assert.True(sut.IsNoob); 

<b>Asserting on Numeric Values:</b><br>
Assert.Equal(3.14, PI);<br>
Assert.NotEqual(3.14, PI);<br>
Assert.InRange(sut.Health, 101, 200);<br> 

<b>Making Assertions Against String Values:</b><br>
Assert.Equal("Sarah Smith", sut.FullName);<br>
Assert.Equal("Sarah Smith", sut.FullName, ignoreCase: true);<br>
Assert.StartsWith("Sarah", sut.FullName);<br>
Assert.EndsWith("Smith", sut.FullName);<br>
Assert.Contains("Long Bow", sut.Weapons);<br>
Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);<br>

<b>Asserting Null Values:</b><br>
Assert.Null(sut.Nickname);<br>

<b>Making Asserts Against Object Types:</b><br>
Assert.IsType(enemy);<br>
Assert.IsNotType(enemy);<br>

<b>Asserting on Object Instances:</b><br>
We can also write tests to check that two object references are equal that is they point to the same object. To do so,<br>
Assert.Same(enemy1, enemy2);<br>
Assert.NotSame(enemy1, enemy2);<br>

<b>Asserting That Code Throws the Correct Exceptions:</b><br>
During test execution, if an exception is thrown, then the test will automatically fail. But sometimes we want to check that our code is actually throwing exceptions at the correct times.<br>
Assert.Throws(() => sut.Create(null));<br>

<b>Asserting That Events Are Raised:</b><br>
In addition to Asserting that during execution an exception should be thrown, we can also assert that events are raised.<br>
Assert.Raises(…)
 

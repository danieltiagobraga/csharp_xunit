/*
    Unit tests have normally 3 phases:

        Arrange phase:
            Set things up
            Create object instance
            Create test data/inputs

        Act phase
            Execute production code
            Call methods
            Set properties

        Assert phase
            Check results 
            Tests passes/fails

    
    Command line execute: dotnet test --filter Category=Sum
*/
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private readonly ITestOutputHelper _output; // To write custom test output messages
        private readonly ICalculator _calculator;

        public CalculatorShould(ITestOutputHelper output) 
        {
            _output = output;
            _calculator = new Calculator();
        }

        [Fact]                                      // Indicates this method is a unit test
        [Trait("Category", "Sum")]                  // Create a new category 
        public void TestSum2And2()
        {
            // Arrange Phase
            //Calculator c = new();

            // Act Phase
            var sum = _calculator.Sum(2, 2);

            // Assert Phase 
            Assert.Equal(4, sum);
        }

        [Fact(Skip ="Don't run along the other tests")]
        public void TestSum4And4() {
            // Arrange Phase
            //Calculator c = new();

            // Act Phase
            var sum = _calculator.Sum(4, 4);

            // Assert Phase 
            Assert.Equal(8, sum);
        }

        [Fact]
        public void TestSum6And6() {

            _output.WriteLine("Logging TestSum6And6 run");

            // Arrange Phase
            //Calculator c = new();

            // Act Phase
            var sum = _calculator.Sum(6, 6);

            // Assert Phase 
            Assert.Equal(12, sum);
        }

        /*
            Data driven tests

            InlineData we can use this attribute to pass data to our test
        */
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        public  void TestSum(int n1, int n2)
        {
            // Arrange Phase
            // Calculator c = new();

            // Act Phase
            var sum = _calculator.Sum(n1, n2);

            // Assert Phase 
            Assert.Equal(n1 + n2, sum);
        }

         /*
            Data driven tests

            Get data from custom attribute
        */
        [Theory]
        [SumData]
        public void TestSumCustomAttribute(int n1, int n2)
        {
            // Arrange Phase

            // Act Phase
            var sum = _calculator.Sum(n1, n2);

            // Assert Phase 
            Assert.Equal(n1 + n2, sum);
        }        
    }



    public class SumData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {1, 2};
            yield return new object[] {2, 2};
            yield return new object[] {3, 5};
        }
    }

}

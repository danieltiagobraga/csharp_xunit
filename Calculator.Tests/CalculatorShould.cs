using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void TestSum2And2()
        {
            // Arrange Phase: 
            // Set things up
            // Create object instance
            // Create test data/inputs)
            Calculator c = new Calculator();

            // Act Phase:
            // Execute production code
            // Call methods
            // Set properties
            var sum = c.Sum(2, 2);

            // Assert Phase 
            // Check results 
            // Tests passes/fails
            Assert.Equal(4, sum);
        }
    }
}

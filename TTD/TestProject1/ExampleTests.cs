using ConsoleApp1.Classes;
using FluentAssertions;

namespace TestProject1.Tests
{
	public class ExampleTests
	{
		// Given an int, return the sum of all digits in the number.
		// If the number is negative, all digits are counted as negative.
	
		// 456 -> 4 + 5 + 6 = 15
		//-456 -> -4 - 5 - 6 = -15

		//Returns 0 if the input can't be parsed.

		[Theory]
		[InlineData(456, 15)]
		public void ExampleClass_SumDigits_ReturnPositiveSum(int value, int expectedResult)
		{
			// Arrange
			ExampleClass exampleClass = new ExampleClass();

			// Act
			int result = exampleClass.SumDigits(value);

			// Assert
			result.Should().Be(expectedResult);
			result.Should().BePositive();
		}

		[Theory]
		[InlineData(-999, -27)]
		public void ExampleClass_SumDigits_ReturnNegativeSum(int value, int expectedResult)
		{
			// Arrange
			ExampleClass exampleClass = new ExampleClass();

			// Act
			int result = exampleClass.SumDigits(value);

			// Assert
			result.Should().Be(expectedResult);
			result.Should().BeNegative();
		}
	}
}
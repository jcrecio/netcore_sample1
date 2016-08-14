using Fibonacci;
using System;
using Xunit;
using System.Linq;
using FluentAssertions;

namespace FibonacciTests
{
	public class FibonacciGenerator
	{
		public class Generate
		{
			private Fibonacci.FibonacciGenerator Target { get; } = new Fibonacci.FibonacciGenerator();

			[Fact]
			public void Should_Return_1_When_FirstNumberInSerie_IsCalculated()
			{
	            var fibonaccis = Target.Generate(1);

				fibonaccis.Should().Contain(1);
			}

			[Fact]
			public void Should_Return_Empty_When_IndexZeroNumber_IsCalculated()
			{
				var fibonaccis = Target.Generate(0);
				fibonaccis.Count().Should().Be(0);
			}

			[Fact]
			public void Should_Return_1_When_SecondNumberInSerie_IsCalculated()
			{
				var fibonaccis = Target.Generate(2);
				fibonaccis.Should().Contain(1);
			}

			[Fact]
			public void Should_Return_2_When_ThirdNumberInSerie_IsCalculated()
			{
				var fibonaccis = Target.Generate(3);
				fibonaccis.Should().Contain(2);
			}

			[Fact]
			public void Should_Return_2_When_FourthNumberInSerie_IsCalculated()
			{
				var fibonaccis = Target.Generate(4);
				fibonaccis.Should().Contain(2);
			}

			[Fact]
			public void Should_Return_3_When_FourthNumberInSerie_IsCalculated()
			{
				var fibonaccis = Target.Generate(4);
				fibonaccis.Should().Contain(3);
			}
		}
	}
}
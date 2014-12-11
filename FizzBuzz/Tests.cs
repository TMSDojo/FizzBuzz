using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
   [TestFixture]
   public class Tests
   {
      private IFizzBuzzKata target;

      [SetUp]
      public void Setup()
      {
         target = new FizzBuzzImpl();
      }

      [Test]
      public void one_should_be_1()
      {
         target.Answer(1).Should().Be("1");
      }

      [Test]
      public void two_should_be_2()
      {
         target.Answer(2).Should().Be("2");
      }

      [Test]
      public void four_should_be_4()
      {
         target.Answer(4).Should().Be("4");
      }

      [Test]
      public void three_should_be_fizz()
      {
         target.Answer(3).Should().Be("fizz");
      }

      [Test]
      public void five_should_be_buzz()
      {
         target.Answer(5).Should().Be("buzz");
      }

      [Test]
      public void nine_should_be_fizz()
      {
         target.Answer(9).Should().Be("fizz");
      }

      [Test]
      public void ten_should_be_fizz()
      {
         target.Answer(10).Should().Be("buzz");
      }
      
      [Test]
      public void fifteen_should_be_fizzbuzz()
      {
         target.Answer(15).Should().Be("fizzbuzz");
      }

      [Test]
      public void thirty_should_be_fizzbuzz()
      {
         target.Answer(30).Should().Be("fizzbuzz");
      }
   }
}

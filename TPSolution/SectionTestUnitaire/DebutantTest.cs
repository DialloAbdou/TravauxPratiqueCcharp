using FluentAssertions;

namespace SectionTestUnitaire
{
    public class DebutantTest
    {
        private Debutant _debutantSession = new Debutant();
        public DebutantTest()
        {

        }

        [Fact]
        public void GetFizzBuzz_Should_Be_Return_1_When_Value_Equalt_TO_1()
        {
            //Arange

            //Act
            var result = _debutantSession.GetFizzBuzz(1);
            //Assertion
            result.Should().Be("1");
        }

        [Fact]
        public void GetFizzBuzz_Should_Be_Return_Fizz_If_Value_Divided_By_3()
        {
            //Arange
            var fizz = "Fizz";
            //Act
            var result = _debutantSession.GetFizzBuzz(3);
            //Assertion
            result.Should().Be(fizz);
        }

        [Fact]
        public void GetFizzBuzz_Should_Be_Return_Buzz_If_Value_Divided_By_5()
        {
            //Arange
            var fizz = "Buzz";
            //Act
            var result = _debutantSession.GetFizzBuzz(5);
            //Assertion
            result.Should().Be(fizz);
        }

        [Fact]
        public void GetFizzBuzz_Should_Be_Return_FizzBuzz_If_Value_Divided_By_3_And_5()
        {
            //Arange
            var fizz = "FizzBuzz";
            //Act
            var result = _debutantSession.GetFizzBuzz(15);
            //Assertion
            result.Should().Be(fizz);
        }

        [Fact]
        public void RemoveAtPosition_Should_Be_Deleted_the_First_Caractere_of_Strin_when_index_Less_OR_Equal_to_Zero()
        {
            //Arange
            var fizz = "Fizz";
            //Act
            var result = _debutantSession.RemoveAtPosition(fizz, 0);
            //Assertion
            result.Should().Be("izz");
        }

        [Fact]
        public void RemoveAtPosition_Should_Be_Deleted_the_Last_Caractere_of_Strin_when_indexe_is_More_than_String_Length()
        {
            //Arange
            var fizz = "Fizz";
            int index = fizz.Length;
            //Act
            var result = _debutantSession.RemoveAtPosition(fizz, index);
            //Assertion
            result.Should().Be("Fiz");
        }

        [Fact]
        public void RemoveAtPosition_Should_Be_Deleted_Caractere_AtPosition_String()
        {
            //Arange
            var fizz = "Fizz";
            int index = 1;
            //Act
            var result = _debutantSession.RemoveAtPosition(fizz, index);
            //Assertion
            result.Should().Be("Fzz");


        }
    }
}
using Software_Tests;

namespace Tests
{
    public class Tests
    {
        /// <summary>
        /// Test the functionality of a method that adds two numbers together:
        /// </summary>
        [Fact]
        public void AdditionTest()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        /// <summary>
        /// Test the functionality of a method that checks if a string is a palindrome:
        /// </summary>
        [Fact]
        public void PalindromeTest()
        {
            var wordChecker = new WordChecker();
            var result = wordChecker.IsPalindrome("racecar");
            Assert.True(result);
        }

        /// <summary>
        /// Test the functionality of a method that retrieves the value of a specific key in a dictionary:
        /// </summary>
        [Fact]
        public void DictionaryValueTest()
        {
            var dictionary = new Dictionary<string, int> { { "key1", 1 }, { "key2", 2 } };
            var valueChecker = new DictionaryValueChecker(dictionary);
            var result = valueChecker.GetValue("key1");
            Assert.Equal(1, result);
        }

        /// <summary>
        /// Test the functionality of a method that sorts a list of integers:
        /// </summary>
        [Fact]
        public void SortTest()
        {
            var sorter = new ListSorter();
            var result = sorter.Sort(new List<int> { 3, 2, 1 });
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        /// <summary>
        /// Test the functionality of a method that reverses a string:
        /// </summary>
        [Fact]
        public void ReverseTest()
        {
            var reverser = new StringReverser();
            var result = reverser.Reverse("Hello, World!");
            Assert.Equal("!dlroW ,olleH", result);
        }

        /// <summary>
        /// Test the functionality of a method that checks if a given year is a leap year
        /// </summary>
        [Fact]
        public void CheckLeapYear()
        {
            var yearChecker = new YearChecker();
            var isLeap = yearChecker.IsLeap(2000);
            Assert.True(isLeap);
        }

        /// <summary>
        /// Test the functionality of a method that get the count of vowels in a string
        /// </summary>
        [Fact]
        public void CountVowels()
        {
            var stringProcessor = new StringProcessor();
            var count = stringProcessor.CountVowels("Hello, World!");
            Assert.Equal(3, count);
        }

        /// <summary>
        /// Test the functionality of a method that converts fahrenheit to celsius
        /// </summary>
        [Fact]
        public void FahrenheitToCelsius()
        {
            var temperatureConverter = new TemperatureConverter();
            var celsius = temperatureConverter.FahrenheitToCelsius(212);
            Assert.Equal(100, celsius);
        }

        /// <summary>
        /// Test the functionality of a method that validate an email address
        /// </summary>
        [Fact]
        public void EmailValidationTest()
        {
            var validator = new EmailValidator();
            var isValid = validator.Validate("email@example.com");
            Assert.True(isValid);


        }

        /// <summary>
        /// Test the functionality of a method that checks if a given number is prime or not
        /// </summary>
        [Fact]
        public void PrimeCheckTest()
        {
            var primeChecker = new PrimeChecker();
            var isPrime = primeChecker.IsPrime(11);
            Assert.True(isPrime);
        }
    }
}
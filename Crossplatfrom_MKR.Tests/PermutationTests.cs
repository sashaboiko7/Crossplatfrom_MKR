using Crossplatform_MKR;

namespace Crossplatfrom_MKR.Tests
{
    [TestFixture]
    public class PermutationTests
    {
        [Test]
        public void Test_PositiveCase()
        {
            string result = PermutationSolver.Solve(123, 321, 444);

            Console.WriteLine($"Result: {result}");

            Assert.That(result, Is.EqualTo("YES\n123 321"));
        }

        [Test]
        public void Test_NegativeCase()
        {
            string result = PermutationSolver.Solve(123, 321, 500);

            Console.WriteLine($"Result: {result}");

            Assert.That(result, Is.EqualTo("NO"));
        }

        [Test]
        public void Test_LeadingZeros()
        {
            string result = PermutationSolver.Solve(102, 201, 303);

            Console.WriteLine($"Result: {result}");

            Assert.That(result, Is.EqualTo("YES\n102 201"));
        }

        [Test]
        public void Test_MinimalX()
        {
            string result = PermutationSolver.Solve(312, 123, 444);

            Console.WriteLine($"Result: {result}");

            Assert.That(result, Is.EqualTo("YES\n123 321"));  // Μ³ν³μΰλόνε x = 123
        }

        [Test]
        public void Test_ZeroCase()
        {
            string result = PermutationSolver.Solve(0, 123, 123);

            Console.WriteLine($"Result: {result}");

            Assert.That(result, Is.EqualTo("YES\n0 123"));
        }
    }
}
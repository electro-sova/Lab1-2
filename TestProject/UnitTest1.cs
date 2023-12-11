namespace TestProject
{ //sfdfsdf
    public class Tests
    {
        [Test]
        public void Sort_Test1()
        {
            int[] array = new int[10] { 1, 7, 10, 24, 65, 12, 56, 5, 1, 2 };
            int[] array_correct = new int[10] { 1, 1, 2, 5, 7, 10, 12, 24, 56, 65 };


            CollectionAssert.AreEqual(Program.Sort(array), array_correct);
        }

        [Test]
        public void Sort_Test2()
        {
            int[] array = new int[10] { -1, -2, 3, -4, -5, -6, 7, 8, 9, 10 };
            int[] array_correct = new int[10] { -6, -5, -4, -2, -1, 3, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(Program.Sort(array), array_correct);
        }

        [Test]
        public void Test_Palindrome_1()
        {
            string str = "a";

            Assert.False(Program.Palindrome(str));
        }
        [Test]
        public void Test_Palindrome_2()
        {
            string str = string.Empty;

            Assert.False(Program.Palindrome(str));
        }
        [Test]
        public void Test_Palindrome_3()
        {
            string str = "111";

            Assert.True(Program.Palindrome(str));
        }

        [Test]
        public void Test_Factorial_1()
        {
            Assert.That(Program.Factorial(6), Is.EqualTo(720));
        }
        [Test]
        public void Test_Factorial_2()
        {
            Exception ex = Assert.Throws<Exception>(() => Program.Factorial(-10)); // ыавыпавррпвроывфыв
            Assert.That(ex.Message, Is.EqualTo("Число меньше нуля"));
        }

        [Test]
        public void Test_Fibonacci_1()
        {
            Assert.That(Program.Fibonacci(14), Is.EqualTo(377));
        }

        [Test]
        public void Test_Fibonacci_2()
        {
            Exception ex = Assert.Throws<Exception>(() => Program.Fibonacci(-1));

            Assert.That(ex.Message, Is.EqualTo("Число меньше нуля"));
        }

        [Test]
        public void Test_Stepen_1()
        {
            Assert.That(Math.Round(Program.Stepen(1.2, 2.5), 4), Is.EqualTo(1.5774));
        }
        [Test]
        public void Test_Stepen_2()
        {
            Exception ex = Assert.Throws<Exception>(() => Program.Stepen(-0.551, 0.111));

            Assert.That(ex.Message, Is.EqualTo("Число меньше или равняется нулю"));
        }
        [Test]
        public void Test_Stepen_3()
        {
            Exception ex = Assert.Throws<Exception>(() => Program.Stepen(0.0, -0.421));

            Assert.That(ex.Message, Is.EqualTo("Число меньше или равняется нулю"));
        }

        [Test]
        public void Test_PrimeNumber_1()
        {
            Assert.True(Program.PrimeNumber(3));
            Assert.True(Program.PrimeNumber(7));
            Assert.True(Program.PrimeNumber(11));
        }

        [Test]
        public void Test_PrimeNumber_2()
        {
            Assert.False(Program.PrimeNumber(4));
            Assert.False(Program.PrimeNumber(8));
            Assert.False(Program.PrimeNumber(12));
        }
    }
}
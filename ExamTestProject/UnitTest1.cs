using ExamClassLibrary;

namespace ExamTestProject
{
	public class UnitTest1
	{
		[Fact]
		public void ExamplesTest1()
		{
			double x = 3;
			double expected = 9;
			
			Examples examples = new Examples();

			double actual  = examples.ExampleFirst(x);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ExamplesTest2()
		{
			double x = 6;
			double expected = 36;

			Examples examples = new Examples();

			double actual = examples.ExampleFirst(x);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ExamplesTest3()
		{
			double x = 7;
			double expected = 49;

			Examples examples = new Examples();

			double actual = examples.ExampleFirst(x);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ExamplesTest4()
		{
			double x = 1;
			double expected = 1;

			Examples examples = new Examples();

			double actual = examples.ExampleFirst(x);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ExamplesTest5()
		{
			double x = 0;
			double expected = 0;

			Examples examples = new Examples();

			double actual = examples.ExampleFirst(x);
			Assert.Equal(expected, actual);
		}

	}
}
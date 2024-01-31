namespace ConsoleApp1.Classes
{
	public class ExampleClass
	{
		/// <summary>
		/// Takes an int and returns the sum of all digits in the number.
		/// </summary>
		public int SumDigits(int value)
		{
			// check if value is negative
			bool isNegative = value < 0;

			// convert input to string
			string valString = Math.Abs(value).ToString();

			// make temp int for new value
			int tmpInt = 0;

			// loop through each character in string
			foreach (var character in valString)
			{
				// check if character is a digit
				if (int.TryParse(character.ToString(), out int digit))
				{
					// add digit to temp int
					tmpInt += isNegative ? -digit : digit;
				}
				else
				{
					// return 0 early if character is not a digit
					return 0;
				}
			}

			// return the temp int
			return tmpInt;
		}
	}
}

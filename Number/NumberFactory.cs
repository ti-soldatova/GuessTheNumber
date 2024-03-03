namespace GuessTheNumber.Number
{
    internal static class NumberFactory
    {
        public static INumber CreateNumber(string startNum, string endNum)
        {
            INumber numberResult;

            if (int.TryParse(startNum, out int _) && int.TryParse(endNum, out int _))
            {
                numberResult = new IntNumber();
            }
            else if (double.TryParse(startNum, out double _) && double.TryParse(endNum, out double _))
            {
                numberResult = new DoubleNumber();
            }
            else
                throw new FormatException("Непонятно, с каким форматом играем");

            numberResult.SetRandomNumber(startNum, endNum);

            return numberResult;
        }
    }
}

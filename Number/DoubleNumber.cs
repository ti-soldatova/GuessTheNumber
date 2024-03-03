namespace GuessTheNumber.Number
{
    internal class DoubleNumber : INumber
    {
        public double Value { get; private set; }

        public void SetRandomNumber(string start, string end)
        {
            Random random = new Random();

            double min = double.Parse(start);
            double max = double.Parse(end);

            double value = random.NextDouble() * (max - min) + min;
            Value = Math.Round(value, 1);

            Console.WriteLine("Внимание! Игра завязывается сложная, поэтому все числа будут округлены до одного знака после запятой!");
        }

        public Result CheckNumber(string number)
        {
            double num = double.Parse(number);
            num = Math.Round(num, 1);

            bool isWin = num == Value;
            string message;

            if (isWin)
            {
                message = "Поздравляем, вы супер пупер крут!";
            }
            else
            {
                message = num < Value ? "Ваше число меньше" : "Ваше число больше";
            }

            return new(isWin, message);
        }
    }
}

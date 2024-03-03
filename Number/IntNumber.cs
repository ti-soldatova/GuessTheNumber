namespace GuessTheNumber.Number
{
    internal class IntNumber : INumber
    {
        public int Value { get; private set; }

        public void SetRandomNumber(string start, string end)
        {
            Random random = new Random();

            int min = int.Parse(start);
            int max = int.Parse(end);

            Value = random.Next(min, max);
        }

        public Result CheckNumber(string number)
        {
            int num = int.Parse(number);

            bool isWin = num == Value;
            string message;

            if (isWin)
            {
                message = "Поздравляем, вы выиграли!";
            }
            else
            {
                message = num < Value ? "Ваше число меньше" : "Ваше число больше";
            }

            return new(isWin, message);
        }
    }
}

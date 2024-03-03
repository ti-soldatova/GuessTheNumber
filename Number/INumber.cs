namespace GuessTheNumber.Number
{
    internal interface INumber
    {
        void SetRandomNumber(string start, string end);
        public Result CheckNumber(string number);
    }
}

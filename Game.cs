using GuessTheNumber.Number;

namespace GuessTheNumber
{
    internal class Game
    {
        public static void Play()
        {
            Console.WriteLine("Введите количество попыток:");
            string attemtsCountStr = Console.ReadLine();
            int attemtsCount = Convert.ToInt32(attemtsCountStr);

            Console.WriteLine("Введите диапазон таким образом: начало;конец");
            string[] range = Console.ReadLine().Split(';');
            
            if (range.Length != 2)
            {
                throw new ArgumentException("Неверно введен диапазон");
            }

            string startRange = range[0];
            string endRange = range[1];

            INumber number = NumberFactory.CreateNumber(startRange, endRange); 

            while (attemtsCount != 0)
            {
                Console.WriteLine("Введите проверяемое число:");
                string enteredNumber = Console.ReadLine();

                Result result = number.CheckNumber(enteredNumber);

                Console.WriteLine(result.Message);

                if (result.IsWin)
                    break;

                attemtsCount--;
            }

            if (attemtsCount == 0)
            {
                Console.WriteLine("Количество попыток закончилось");
            }
        }
    }
}

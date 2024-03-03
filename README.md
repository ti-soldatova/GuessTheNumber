Реализация игры «Угадай число».
Правила игры:
Программа рандомно генерирует число, пользователь должен угадать это число. При каждом вводе числа программа пишет больше или меньше отгадываемого. Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.

Польза: практическое применение SOLID принципов.
В этой игре можно играть с разными типами чисел. Пока реализовано только для типов Int и Double, но благодаря применению SOLID, это легко расширяемо и можно добавлять классы для других типов. Даже если мы например захотим вводить числа строками))) Нужно будет всего лишь добавить класс StringNumber

S (Single Responsibility Principle)
Все классы типов (IntNumber, DoubleNumber и потенциально последующие), отвечают только за свою логику определения рандомного числа и проверки вводного числа, тем самым имея одну ответственность.

O (Open/Closed Principle)
Добавление новых типов чисел не потребует никаких изменений существующего класса Game.

L (Liskov Substitution Principle)
Все классы чисел реализуют интерфейс INumber, обеспечивая взаимозаменяемость объектов этих классов.

I (Interface Segregation Principle)
Интерфейс INumber имеет только нужные для числа в игре методы: SetRandomNumber(установка рандомного числа) и CheckNumber(проверка вводного числа).

D (Dependency Inversion Principle)
Класс Game зависит от абстракции INumber, а не от конкретных реализаций.

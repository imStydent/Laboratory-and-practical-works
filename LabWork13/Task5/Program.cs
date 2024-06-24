string[] strings = { "Хороший пёс", "Хор", "Хром", "яблоко", "кувалда", "ручка и карандаш - это все что нужно для студента",
    "Яблоки, сегодня, очень кислые", "Бонус за безумный трюк: +50 очков", "некоторые летучие мыши едят фрукты", "У меня закончились идеи"};
int count = 0; 

Console.Write("Введите текс, с которого начинается строка: ");
string userText = Console.ReadLine();

Console.WriteLine("Результаты поиска: ");
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].ToLower().StartsWith(userText.ToLower()))
    {
        count++;
        Console.WriteLine(strings[i]);
    }
}
if (count == 0)
    Console.WriteLine("Результатов, соответствующих критериям поиска, не найднено");

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

string[] FindWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.Write(array[i] + " ");
        }
    }
    return array;
}

System.Console.WriteLine("Сколько слов Вы введете?");
int count = Convert.ToInt32(Console.ReadLine());
string[] array = new string[count];
System.Console.WriteLine("Введите слова, отделяя каждое слово клавишей Enter: ");
FillArray(array); 
FindWords(array);
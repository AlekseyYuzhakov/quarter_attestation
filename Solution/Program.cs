
void NewTask()
{
  Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
  Console.ReadKey();
  Console.WriteLine();
}

int AskForArg(string msg)
{
  Console.WriteLine(msg);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}


string[] CreateStringArray(int length)
{
  string[] array = new string[length];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine($"Введите значение для {i + 1} элемента массива");
    array[i] = Convert.ToString(Console.ReadLine());
  }
  return array;
}

string[] CopyValuefromArrayLessThen3(string[] oldArray, string[] newArray)
{

  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length < 4)
    {
      newArray[i] = oldArray[i];

    }
    else
    {
      newArray[i] = String.Empty;
    }
  }
  return newArray;
}

void PrintArrayWithColor(string[] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.ForegroundColor = (ConsoleColor)i;
    Console.Write($"[{array[i]}]");
  }
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.White;
}

void quarterTask()
{
  Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.");
  NewTask();
  string[] originArray = CreateStringArray(AskForArg("Укажите длину масива"));
  Console.WriteLine("Получили следующий массив");
  PrintArrayWithColor(originArray);
  string[] CopyArray = new string[originArray.Length];
  CopyValuefromArrayLessThen3(originArray, CopyArray);
  Console.WriteLine("Результатом отбора значений содержищих менее 3 символов будет следующий массив ");
  PrintArrayWithColor(CopyArray);
  Console.WriteLine("Спасибо");
}

quarterTask();
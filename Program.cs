/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

string GetNumber(string message){
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result) && result > 0)
    {
      isCorrect = true;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result.ToString();
}

bool isPalindrome(string str){
  bool result = false;
  char[] arr;//input string to array of chars
  char[] arrRevers;//revers of input string
  
  arrRevers = arr = str.ToCharArray();

  int lenght = arr.Length;
  for (int i = 0; i < lenght; i++)
  {
    int reversIndex = lenght - 1 - i;
    // Console.WriteLine($"{arr[i]} and {arrRevers[reversIndex]}");
    if(arr[i] != arrRevers[reversIndex])
    {
      result = false;
      // Console.WriteLine($"{i} and {result}");
      return result;
    }
    else
      result = true;
  }
  return result;
}

string number = GetNumber("Enter number");
string res = isPalindrome(number) ? "Yes" : "No";

Console.WriteLine($"{number} -> {res}");
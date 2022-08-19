Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;
string result = "";

while (i < number)
{

  i++;
  if (number == i)
  {
    result = result + (i * i * i);
  }
  else
  {
    result = result + (i * i * i) + ',';
  }
}

Console.WriteLine(result);
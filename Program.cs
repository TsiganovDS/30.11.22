Console.Write("Введите число М: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        array[i] = Int32.Parse(Console.ReadLine());
    }
    int pozitiv(int[] array)
    {
    int count = 0;
      for (int i = 0; i < array.Length; i++)
      {
          if (array[i] > 0)
          {
              count++;
          }
      } 
    return count;
    }
 
 void PrintArray(int [] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
 PrintArray(array);           
 int Pozitiv = pozitiv(array);            
Console.WriteLine($"Количество чисел больше 0 - {Pozitiv}");
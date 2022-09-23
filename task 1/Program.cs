Console.Write("Введите количество чисел: ");
int Quantity=  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите числа для анализа: ");
int Count=0;

    int [] Arr= new int [Quantity];
    for (int i = 0; i < Quantity; i++)
    {
        Arr [i] =  Convert.ToInt32(Console.ReadLine());
    }

int PositiveNumber=0;

    for (int i = 0; i < Quantity; i++)
    {
        if(Arr[i]>0)
        {
            PositiveNumber+=1;
        }

    }
Console.WriteLine($"Среди введенных чисел положительных= {PositiveNumber}");
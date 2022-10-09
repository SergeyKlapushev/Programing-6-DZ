// See https://aka.ms/new-console-template for more information
 

int N = Start("Введите 5-ти значное число: ");

int Start(string message)
{
    Console.Write(message);
    int N1 = Convert.ToInt32(Console.ReadLine());
    return N1;
}

string Raschet(int Number)
{
    if (Number < 10000 || Number > 99999)
    {
        string Otvet = "Вы ввели не 5-ти значное число";
        return Otvet;
    }

    else 
    {
        if(N/10000 == N%10 && N/1000%10 == N%100/10 && N/100%10 == N%1000/100)
        {
            string Otvet = $"Число {N} является палиндромом";
            return Otvet;
        }
        else
        {
            string Otvet = $"Число {N} не является палиндромом";
            return Otvet;
        }
    }
}

string Otvet = Raschet(N);
Console.WriteLine(Otvet);






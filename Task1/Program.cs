/*  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.   */

//Вводим число

int Start(string message)
{
    Console.Write(message);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}              


string Raschet(int N)
{
    if (N >= 10000 && N <= 99999)
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
    else {return "Вы ввели не пятизначное число";}
    
}

int Number = Start("Введите 5-ти значное число: ");
string Otvet = Raschet(Number);
Console.WriteLine(Otvet);
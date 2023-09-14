// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

m1:
Console.WriteLine("Enter number of elements >=0: ");
int n = int.Parse(Console.ReadLine());
if(n<=0) goto m1;
m2:
Console.WriteLine("Enter lenght of elements >=0: ");
int m = int.Parse(Console.ReadLine());
if(m<=0) goto m2;

string[] init = new string[n];


 for (int i = 0; i < n; i++)
    {
        int k = RNDNUM();
        init[i] = GW(k);
        Console.Write($"{init[i]}  ");
    }
    Console.Write(" Result is:  ");
    int j=0;
    string b;
    for (int i = 0; i < n; i++)
        {
            b = init[i];
            if (b.Length<4)
                {
                    string[] arrRes = new string[j+1];
                    arrRes[j] = b;
                    Console.Write($"{arrRes[j]}  ");
                    j++;
                }
        }



int RNDNUM()
// return random number from 1 to desired number
{
    Random rnd = new Random();
    int rand = 0;
    rand = rnd.Next(1, m);

    return rand;
}    


string GW(int r)
// return random string
{
    string randWord = "";
    Random rand = new Random();
    for (int i = 0; i < r; i++)
        {
               
            randWord += (char)rand.Next(33, 126);
              
        }
    return randWord;
}

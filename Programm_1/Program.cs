// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] Arr = INITARR();
Console.Write("Result is: ");
NEWARR(Arr);


string[] INITARR()
{

string[] arr = new string[4];

for(int i=0; i<4; i++)
    {
        arr[i] = EnterVariable();
    }
for(int i=0; i<4; i++)
    {
        Console.Write(arr[i]+"  ");
    }
return arr;
}

void NEWARR(string[] arr)
{
    int j=0;
    string b;
    for (int i = 0; i < 4; i++)
        {
            b = arr[i];
            if (b.Length<4)
                {
                    string[] newArr = new string[j+1];
                    newArr[j] = b;
                    Console.Write($"{newArr[j]}  ");
                    j++;
                }
        }
}


string EnterVariable()
{
    string n = "";
    Console.Write("Please, enter element in Array: ");
    n = Console.ReadLine();
    return n;
}


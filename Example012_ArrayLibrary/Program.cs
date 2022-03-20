void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(1, 10);

        index++;
    }
}

//void - метод, который ничего не возвращает
void PrintArray( int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col [position]);
        position++;
    }
}


int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // искусственный прием (если элемент отсутствует, возвращаем -1)
                       // это можно интерпритировать, как "данный элемент не найден"

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // указывает на то, что показываем только первую цифру, после выполнения 
                   // условия отображается переменная, и условия считается завершенным
        }
        index++;
    }
    return position;
}
int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
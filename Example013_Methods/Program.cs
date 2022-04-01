// Вид 1 - ничего не принимают и ничего не возвращают
/*void Method1()
{
    Console.WriteLine("The author is ...");
}

Method1(); // при вызове метода не забывем о скобках


// Вид 2 - что-то принимают, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "The text of the message"); // именнованный аргумент, если их более одного, то это отличный способ

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4); // явное указание аргумента, при этом не надо писать их по порядку

// Вид 3 - ничего не принимают, но что-то возвращают
int Method3 () //обязательно нужно указать тип возвращаемых данных и добавить return
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/
//Вид 4 - что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
   /* for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    */
}

string res = Method4 (10, "asdf");
Console.WriteLine(res);
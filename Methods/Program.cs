// Виды методов

// Вид 1 - ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ..."); // например, для указания авторства на странице
}
Method1(); //для вызова метода (обязательно скобки!)


// Вид 2 - ничего не возвращает, но может принимать какие-нибудь аргументы
void Method2(string msg)
// ВозвращаемыйТипДанных Имя Метода([ТипДанных1 ИмяАргумента1, ...])
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);        
        i++; // инкремент - увеличение счетчика на единичку, декримент - уменьшение счетчика на единицу
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст");

// Вид 3 - что-то возвращает, но ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - что-то принимаети что-то возвращает
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
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++) // запись цикла без while, все условия в одной сроке: счетчик, условия для него и инкеремент
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
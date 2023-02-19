// 1 Методы,которые ничего не принимаю и ничего не возвращают
/*void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();*/
//2 Метод, который принимает и ничего не возвращает
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "текст сообщения");*/

/*void Method21(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "текст",count:4);*/
//3 методы, которые не принимают, но возвращают
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/
//4 метод, который принимает и возвращает
/*string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
    result = result +text;
    i++;
}
return result;
}
string res = Method4(10,"asdf");
Console.WriteLine(res);*/

//цикл for
/*string Method4(int count, string text)
{
string result = String.Empty;
for(int i =0; i<count; i++)
{
    result = result +text;
}
return result;
}
string res = Method4(10,"_o_");
Console.WriteLine(res);*/

//цикл в цикле
/*for (int i=2; i <= 10; i++)
{
for (int j=2; j <= 10; j++)
{
    Console.WriteLine($"{i} x {j} = {i*j}");
}
Console.WriteLine();
}*/

//1задача: проблемы в тексте заменить черточками. к замен на К, С замен на с
/*string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винценгероде,"
                + "вы бы взяли приступом согласие прусского короляю "
                +"Вы так красноречивы. Вы дадите мне чаю?";*/
//string s = "qqo"
//            012
// s[2]=o
/*string Replace(string text,char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i=0;i<length;i++)
    {
        if (text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText=Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'С', 'с');
Console.WriteLine(newText);*/

int[] arr={1,5,4,3,2,6,7,1,1};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i=0;i<array.Length; i++)
    {
        int minPosition=i;
        for (int j=i+1;j<array.Length-1;j++)
        {
            if(array[i]<array[minPosition]) minPosition =j;
        }
        int temporary=array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
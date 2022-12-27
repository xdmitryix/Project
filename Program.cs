// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



// int[] NumberArrayCharacters(string[] arr)
// {
//     int quantity = 0;
//     int arrayLength= arr.Length;
//     for (int i = 0; i < arrayLength; i++)
//     {
//         int x = arr[i].Length;
//         if (x <= 3)
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }







// string[] arrayBegin = { "hello", "2", "world", ":-)" };
// Console.WriteLine("Исходный массив: [" + string.Join(", ", arrayBegin) + "]");
// int quantity = NumberArrayCharacters(arrayBegin);
// Console.WriteLine(quantity);


// int[] NumberArrayCharacters(string[] arr)
// {
//     int quantity = 0;
//     int arrayLength= arr.Length;
//     for (int i = 0; i < arrayLength; i++)
//     {
//         int x = arr[i].Length;
//         if (x <= 3)
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }







string[] arrayBegin = { "hello", "2", "world", ":-)" };
Console.WriteLine("Исходный массив: [" + string.Join(", ", arrayBegin) + "]");
int quantity = 0;
int arrayLength= arrayBegin.Length;
for (int i = 0; i < arrayLength; i++)
{
    int arrBeg = arrayBegin[i].Length;
    if (arrBeg <= 3)
    {
        quantity++;
    }
}
string[] arrayResult = new string[quantity];








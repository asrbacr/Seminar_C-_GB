// // Решение в группах задач:
// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// // заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

// int[] arrNum = new int[8];

// foreach (var item in arrNum)  //перебор массива
// {
//     Random 
//     System.Console.WriteLine(item);
// }

// new Random().Next([min],[max])

// for (int i = 0; i < arrNum.Length; i++)
// {
    
// }

// int[] arrNum = new int[8];

// for (int i = 0; i < arrNum.Length; i++)
// {
//     Random rnd = new Random();
//     arrNum[i] = rnd.Next(0, 2);
// }

// System.Console.Write($"[{String.Join(",", arrNum)}]\n");

int N = getVar();
System.Console.Write($"[{String.Join(",", genArr(N))}]\n");

// --- FUNC --- //
int[] genArr(int N){
    int[] arrNum = new int[N];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) {}

    return arrNum;
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}
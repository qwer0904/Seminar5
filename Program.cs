Console.Write("Введите номер задачи: ");
int a = 0;
try{
a = Convert.ToInt32(Console.ReadLine());
} catch (System.FormatException){
    Console.Write("Это не номер");
    return;
}

switch (a){

    case 34:
    task34();
    break;

    case 36:
    task36();
    break;

    case 38:
    task38();
    break;

    default: 
    Console.WriteLine("Нет такой задачи(");
    break;
}

// Task 34. Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

int countPos(int[] mass){
    
    int count = 0;
    for(int i = 0; i < mass.Length; i++){
        if(mass[i] % 2 == 0) count++;
    }
    
    return count;
}


void task34(){
    bool complete = false;
    while(complete == false){
        Console.WriteLine("1 - Выполнить\n2 - Выход\n");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a){
            case 1:
            Console.Write("\nВведите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[size];
            for(int i = 0; i < size; i++){
                mass[i] = new Random().Next(100, 999);
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine("\nРезультат: " + countPos(mass) + "\n");
                break;
            case 2:
            complete = true;
            break;
            default: 
            Console.WriteLine("Пожалуйста, выберите один из предложенных вариантов");
            break;
        }

    }
}

// Task36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int sumMass(int[] abc){
    int sum = 0;
    for(int i = 0; i < abc.Length; i++){
        if(i % 2 != 0){
            sum += abc[i];
        }
    }

    return sum;
}

void task36(){
    Console.Write("Введите размер массива: ");
    string a = Console.ReadLine();

    try{
        int num = Convert.ToInt32(a);
        int[] numbers2 = new int[num];
        for(int i = 0; i < numbers2.Length; i++){
            numbers2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Сумма - "+ sumMass(numbers2));
    } catch(FormatException){
        Console.WriteLine("Это не число");
    }
}

// Task38. Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

double[] createArray(int size){
    double[] numbers = new double[size];

    Console.WriteLine("Введите "+ size + " числа:");

    for(int i = 0; i < size; i++){
        numbers[i] = Convert.ToDouble(Console.ReadLine());
    }

    return numbers;
}

void task38(){
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    double[] mass = createArray(size);
    double max = mass[0];
    double min = mass[0];
    Console.WriteLine("Ваш массив: ");
    for (int i = 1; i < size; i++){
        if(max < mass[i]) max = mass[i];
        if(min > mass[i]) min = mass[i];
    }
    Console.WriteLine("Разница между max и min = " + (max-min));
}

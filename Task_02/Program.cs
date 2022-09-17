using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=Convert.ToInt32(ReadLine());
int num2=Convert.ToInt32(ReadLine());
 if (num1>num2){
 WriteLine($"Число {num1} больше числа {num2}");
 }
 else 
 {
    WriteLine($"Число {num2} больше числа {num1}");
 }
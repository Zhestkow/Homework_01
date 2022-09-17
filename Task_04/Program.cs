using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=Convert.ToInt32(ReadLine());
int num2=Convert.ToInt32(ReadLine());
int num3=Convert.ToInt32(ReadLine());
if (num1>num2 && num1>num3){
WriteLine($"Максимальное число {num1}");
}
if (num2>num1 && num2>num3){
 WriteLine($"Максимальное число {num2}");
 }
 if (num3>num2 && num3>num1){
 WriteLine($"Максимальное число {num3}");
 }
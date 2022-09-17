using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=Convert.ToInt32(ReadLine());
if (num1%2!=0){
WriteLine($"{num1} нечетное число");
}
else {
WriteLine($"{num1} четное число");
}
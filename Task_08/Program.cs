using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=Convert.ToInt32(ReadLine());
int idx=1;

while(idx<=num1)
{
    if(idx%2==0)
    {
    Write($" {idx} ");
    }
idx+=1;
}
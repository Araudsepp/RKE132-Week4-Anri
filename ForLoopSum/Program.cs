
int sum = 0;
//i+1
for(int i = 1; i < 11; i++)  //i-- = i-1
{
    Console.WriteLine($"i equals {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;  
}
Console.WriteLine($"Final total: {sum}");

//console.writeline($"Final total {sum}";
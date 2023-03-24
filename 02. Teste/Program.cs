static bool CheckFibonacci(Nullable<int> n)
{
    int a = 0;
    int b = 1;
    if (n < 2) return true;
    
    int c = a + b;
    
    while(c <= n)
    {
        if(c == n) return true;
        a = b;
        b = c;
        c = a + b;
    }
    
    return false;
}

var value = 89;
var result = CheckFibonacci(value);

Console.WriteLine($"Result: {result}");

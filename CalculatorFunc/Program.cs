int a = 5;
int b = 6;


Add(a, b);
Add(10, 100);

Multiply(a, b);
Multiply(10, 100);

Delene(a, b);
Delene(100, 10);

Minus(a, b);
Minus(100, 10);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Delene(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

static void Minus(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}
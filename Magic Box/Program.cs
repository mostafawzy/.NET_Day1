
Console.Write("Enter size (X) of odd Magic Box (X*X): ");
int x = Convert.ToInt32(Console.ReadLine());

int row = 1, col = (x + 1) / 2;
int horizontal_space = 120 / (x + 1), vertical_space = 30 / (x + 1);

int i = 1;
while (i <= x * x)
{
    Console.SetCursorPosition(horizontal_space * col, vertical_space * row);
    Console.Write(i);

    if (i % x == 0)
    {
        row++;
        if (row > x) row = 1;
    }
    else
    {
        row--;
        col--;
        if (row < 1) row = x;
        if (col < 1) col = x;
    }
    i++;
}

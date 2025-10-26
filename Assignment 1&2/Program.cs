

//================================================================ Assignment 1
Console.WriteLine("enter a day number:  ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("The day is Sunday");
        break;

    case 2:
        Console.WriteLine("The day is Monday");
        break;

    case 3:
        Console.WriteLine("The day is Tuseday");
        break;

    case 4:
        Console.WriteLine("The day is Wednsday");
        break;

    case 5:
        Console.WriteLine("The day is Thursday");
        break;

    case 6:
        Console.WriteLine("The day is Friday");
        break;

    case 7:
        Console.WriteLine("The day is Satarday");
        break;

    default:
        Console.WriteLine("The day is out of range. ");
        break;
}


//================================================================ Assignment 2

Console.WriteLine("enter a month number:  ");
int dayMonth = int.Parse(Console.ReadLine());
if (dayMonth >= 1 && dayMonth <= 12)
{
    if (dayMonth == 2)
    {
        Console.WriteLine("number days in this month is 28 or 29");
    }
    else if (dayMonth == 4 || dayMonth == 6 || dayMonth == 9 || dayMonth == 11)
    {
        Console.WriteLine("number days in this month is 30");
    }
    else
    {
        Console.WriteLine("number days in this month is 31");
    }
}
else
{
    Console.WriteLine("out of range of months 1 to 12");
}
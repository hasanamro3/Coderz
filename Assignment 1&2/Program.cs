
//================================================================ Assignment 3 Question 1

float[] array = { 6, 72, 3.4f, 56, 78, 12, 90 };
float sum = 0.0f;float avg = sum / array.Length;
Console.Write("numbers greater than avarage: ");
for (int i = 0; i < array.Length; i++)
{
    sum+= array[i];
    if (i == array.Length - 1)
    {
        foreach (float f in array) 
            if (f > avg) Console.Write(f+", ");
    }
}
Console.WriteLine();
//================================================================ Assignment 3 Question 2

Console.Write("Enter the Array size : ");
int arraySize = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Array elements : ");
double[] array2 = new double[arraySize];

for (int i = 0; i < array2.Length; i++)

   array2[i] = Convert.ToDouble(Console.ReadLine());

Console.Write("Array elements in reverse order: ");
for (int i = array2.Length - 1 ; i >= 0 ; i--)
   
    Console.Write(array2[i]+", ");

Console.WriteLine();
//================================================================ Assignment 3 Question 2

string str = "hello its a repeater ";
Dictionary<char, int> dict = new Dictionary<char, int>();

Console.Write("letters doesnt repeated: ");
foreach (char c in str)
{
    if (dict.ContainsKey(c)) dict[c]++;

    else dict.Add(c, 1);
}

foreach (var d in dict)
{
    if (d.Value == 1) Console.Write(d.Key + " ");
}
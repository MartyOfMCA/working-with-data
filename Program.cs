float number;
Console.Write("Enter any number: ");
number = float.Parse(Console.ReadLine());
float _double = number + number;
Console.WriteLine(_double);
Console.WriteLine();

// TODO: calculate the cube for the given number
float cube = number * number * number;
Console.WriteLine(cube);
Console.WriteLine();
Console.WriteLine();

int totalNumbersToBeReceived;
Console.Write("How many numbers do you wish to receive (Kindly enter the number 2): ");
totalNumbersToBeReceived = int.Parse(Console.ReadLine());
float[] numbers = new float[totalNumbersToBeReceived];
Console.Write("Enter the first number: ");
numbers[0] = float.Parse(Console.ReadLine());
Console.Write("Enter the last number: ");
numbers[1] = float.Parse(Console.ReadLine());

float[] doubles = new float[totalNumbersToBeReceived];
doubles[0] = numbers[0] + numbers[0];
doubles[1] = numbers[1] + numbers[1];
float[] cubes = new float[totalNumbersToBeReceived];
cubes[0] = numbers[0] * numbers[0] * numbers[0];
cubes[1] = numbers[1] * numbers[1] * numbers[1];

Console.Write(doubles[0]);
Console.Write(" ");
Console.WriteLine(doubles[1]);
Console.Write(cubes[0]);
Console.Write(" ");
Console.WriteLine(cubes[1]);

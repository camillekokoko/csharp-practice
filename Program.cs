Console.WriteLine("Hello, World!");


string firstFriend = "Maria";
string secondFriend = "Scott";
string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}.";
Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Scott", "Samantha"));  
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.Contains("Maria"));
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My friends"));

int a = 18;
int b = 6;
int c = a + b;
long d = (long)a + (long)b;
long e = checked(a + b);
Console.WriteLine(d);
float g = 37.3F;
double f = 37.3;  //natural type
double h = g + f;
Console.WriteLine(h);

decimal i = 37.3M; //explicit type
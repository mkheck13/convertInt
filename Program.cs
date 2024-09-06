// Convert to Int

Console.Clear();

string myTitle = "String to Int";
Console.WriteLine(myTitle);

// string breakPoint = "<------------------------New Section------------------------------->";

string strNum = "2";
int intNum = 2;

Console.WriteLine(strNum + intNum);

Console.WriteLine(strNum.GetType());
Console.WriteLine(intNum.GetType());

Console.WriteLine("Please enter a number: ");
string? firstNum = Console.ReadLine();

int conFirstNum = Convert.ToInt32(firstNum);

Console.WriteLine(firstNum.GetType());
Console.WriteLine(conFirstNum.GetType());

Console.WriteLine(intNum + conFirstNum);


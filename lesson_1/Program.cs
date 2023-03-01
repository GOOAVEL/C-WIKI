//========================== BEGIN C# ==========================
// Подготовить программу - |dotnet new console| ~(bush)
// Работаем в Program.cs
// выполнить - |dotnet run| ~(bush)
// variable and function call without _ /кирилицы /123(only at the beginning)

// => выводит в консоль и переводит на новую строчку
Console.WriteLine("2 Hello, World!");
Console.Write("2 Hello, World!"); // => без перехода on new line
Console.ReadLine(); // => return input data (всегда тип string)

// => запрос данных и присваивание in variable типа "string"
string userName = Console.ReadLine();

//.....................................................................
//?++++++++++++++++++++++++++ ТИПЫ ДАННЫХ: +++++++++++++++++++++++++

//TODO#1 INTEGER = целое число      (От -2 147 483 648 до 2 147 483 647)

short a16 = -32_768; // 16 - разрядное целое число со знаком (до 32_767)

int a32 = -2_147_483_648; // create a new variable type integer (до |a32|-1)

long a64 = -9_223_372_036_854_775_808; // 64 - разрядное целое число со знаком 
//(до 9_223_372_036_854_775_807)
// and others...

Console.WriteLine(13 / 5); // => | 2 | т.к тип данных - int

// ----------------------------------------------------------------
//TODO#2 FLOAT/DOUBLE/DECIMAL = число с плавающей точкой/вещественные числа
// от ±5,0 × 10−324 до ±1,7 × 10308

float z1 = 0.33f;     // от От ±1,5 x 10^-45 до ±3,4 x 10^38  (4 байта)
double z2 = 32.4;    // от ±5,0 × 10^−324 до ±1,7 × 10^308   (8 байта)
decimal z3 = 32.4m; // от ±1,0 x 10^-28 до ±7,9228 x 10^28  (16 байта)

int i = 0;
Console.WriteLine(i++);  // 0    x = 1
Console.WriteLine(++i); //  2    x = 2
//--------------------------------------------------------------------

//TODO#3 STRING|CHAR = текст/строка   |''| - one symbol & |""| - more symbols

string lastName = "Melone"; // create a new variable type string
string n = String.Empty; //Empty srting

Convert.ToInt32("34"); // => convert to integer (лучший вариант, конвертирует все)
Int32.Parse("34"); // => convert to integer (worlk only with numbers and will an error)

Console.WriteLine("TAB /t"); // => string tabulation
Console.WriteLine("New Line /n"); // => new string

// the method returning copy string in LOWERCASE
string lastNameLowerCase = lastName.ToLower();
lastName.ToUpper();// in UPERCASE

//---- Конкатенация and string interpolation
char x = '!'; // one symbol

char foor = '4';      // !convert to char in int
int w = foor - '0';

Console.WriteLine("Hello, " + userName);    // => output "Hello, (userName)"
Console.WriteLine("Hello, {0}{1}", userName, x); // => output "Hello, (userName)!
//                   index ^  ^ index   

string example = "— Я думаю, — сказал князь, улыбаясь, — что,"
               + "ежели бы вас послали вместо нашего милого Винценгероде,"
               + "вы бы взяли приступом согласие прусского короля."
               + "Вы так красноречивы. Вы дадите мне чаю?";

// String interpolation
Console.WriteLine($"Hello {userName}"); // => output "Hello, (userName)"

example.Replace(" ", "_"); // => заменят символы
//----------------------------------------

//TODO#4 BOOL = логический тип (false/true) 
bool a = false; // create a new variable type bool

//-------------------------------------------------------------------
//?...........................RANDOM.................................
int min = 0, max = 11;
new Random().Next(min, max); // generate random integer numbers (from 0 to 10)
new Random().Next(16);  // from 0 to 15

//...................................................................
//?+++++++++++++++++++++++++ Условные ветвления +++++++++++++++++++++++++
//Логические операторы И (&&) vs ИЛИ (||).
if (true || false)  //true
{
    System.Console.WriteLine("I`s TRUE!");
}
else if (true && false) //false
{
    System.Console.WriteLine("I`s FALSE!");
} // VSC подсказывает - нет условий для выполнения "else"

// another option
if (true) Console.WriteLine(3 * 3);     // 9
else Console.WriteLine(3 / 3);

//?............................ SWITCH ............................
Console.Write("Enter the number of days of week: ");
string numberDay = System.Console.ReadLine();

switch (numberDay)
{
    case "1": System.Console.WriteLine("Monday"); break;
    case "2": System.Console.WriteLine("Tuesday"); break;
    case "3": System.Console.WriteLine("Wednesday"); break;
    case "4": System.Console.WriteLine("Thursday"); break;
    case "5": System.Console.WriteLine("Friday"); break;
    case "6": System.Console.WriteLine("Saturday"); break;
    case "7": System.Console.WriteLine("Sunday"); break;
    default: System.Console.WriteLine("Input is invalid"); break;
}

//........................................................................
//?++++++++++++++++++++++++ WHile/For/Foreach +++++++++++++++++++++++++++++
while (true)
{
    if (true) Console.WriteLine("Hello");
    break;   // to stop and out loop
}
int q = 0;
do
{
    Console.WriteLine(++q);  // выполнится 2 раза (1,2)
} while (q < 2);

//====================== Another commands ===========================

Console.Clear(); // clear to console (bush)
Console.SetCursorPosition(10, 4); // set cursor position (в данном случае в консоли)
//10 - left position, 4 - up position (символы в консоле начинаются с 0)

// TODO: Dictionary:
//? 1. indent - отступ, абзац.
//? 2. Parse - разбор, структурный анализ
//? 3. String interpolation - Интерполяция строк


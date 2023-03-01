//======================== Functions and Arrays =========================
// function(method) is - подпрограмма 
// In the C# Function принято называть Method
// Method принято называть with capital letter

Console.WriteLine("argument"); // this is METHOD  

//?========================= FUNCTIONS =========================
//TODO #1 The Example Function:
//ReturningType MethodName (Type FirstParametr,Type SecondParametr)
{
    // int Result = FirstParametr +  FirstParametr;  (algorithm)
    //return Result;
}

int a = 5, b = 7;

int Diff(int FirstParametr, int SecondParametr)
{
    return FirstParametr - FirstParametr;
}
//                         < call method
int differenceBetweenAandB = Diff(a, b);  // return -2

//TODO #2 The Example Function:
// Returning Method (without parameters)
int sum() { return 10 + 7; };

//TODO #3 The Example Function:
// void Method (without return and parameters)
void Method3() { Console.WriteLine("Hi!"); };

//TODO #4 The Example Function:
// void Method (without return) with parameters
void Method4(int a, int b) { Console.WriteLine(a + b); };

Method4(a: 2, b: 6); //присвоить значения параметрам

//----------------------------------------------------------
//========================= ARRAYS =========================
//The Example Array:
//Type[] ArrayName = {value1,values2};   // first option 
//Type[] ArrayName = new int[10];       // second option 

int[] array = { 1, 2, 6, 7, 7 };   // first option 
array[0] = 65;   // overwrite the first element of the array
Console.WriteLine(Diff(array[0], array[3])); // 58

int[] array2 = new int[10]; // create an array of 10 elements (all zero) {0,0,0}
int[] array3 = new int[] { 1, 2, 3, 4, 5 };    // third option 
int[] array4 = new int[5] { 1, 2, 3, 4, 5 };  // fourth option 

string word = "hello";
char[] array6 = word.ToCharArray(); // разделить на массив символов

string text = String.Join("", array4); // Join - (соеденить) elements of array
string[] arrayFour = text.Split(""); // Split - (разделить) string in array

//TODO foreach
foreach (var item in array)
{
    Console.WriteLine(item); // show all elements in the array
    // { 1, 2, 6, 7, 7 }
}
//?====================== Another commands ===========================

Console.WriteLine(DateTime.Now); // show the date (local)
Console.WriteLine(DateTime.Now.Year); // show the date (Year)
string n = String.Empty; //Empty srting

//---------------------------------------------------------------------
// TODO: Dictionary:
//? 1. overwrite - переписывать, затирать
//? 2. capital - капитал, столица, заглавная буква
//? 3. void - пустота, вакуум, пробел

//======================== Functions and Arrays =========================
// function(method) is - подпрограмма 
// In the ЯП C# Function принято называть Method
// Method приянято называть with capital letter

Console.WriteLine("argument"); // this is METHOD  

//========================= FUNCTIONS =========================
//The Example Function:
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

// void Method (without return)
void Method() { System.Console.WriteLine("Hi!"); };

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

// TODO: Dictionary:
//? 1. overwrite - переписывать, затирать
//? 2. capital - капитал, столица, заглавная буква
//? 3. void - пустота, вакуум, пробел

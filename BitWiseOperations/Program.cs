//Bitwise Explained 

//bit shifting (0 or 1) byte => 8bits
//bit shifting is when a series of bits changes order 
//with bits either left or right 
//to perform mathematical operarations
//0 false 1 true

//bitwise compliment operator 
//change zeroses to ones and vice versa
//rule (add one to the value and negate it) e.i compliment of 12 is -13

using System.Diagnostics;
using System.Globalization;

int bytefData = 13; //00001101 => 11110010
System.Diagnostics.Debug.WriteLine(~bytefData);

//left shift operator
//shift all the bits (use of it is multiplication)

int i = 2;  //00000010
Debug.WriteLine(i << 1); //000000100 => 4 
//right shit is the inverse if left was used for X THUS %


//& OPERATION 
int x = 33; //00100001
int y = 129; //1000001
Debug.WriteLine(x & y); //00000001


//compound 
//basicaly perform and operation and also asss=ign it to a var
int g = 90;
int h = 101;
g <<= 2;
Debug.WriteLine(g);

g |= h ; //OR operation 
Debug.WriteLine(g);

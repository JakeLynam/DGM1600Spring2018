using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour 
{


public int A = 10;
public int B = 10;
public int C = 10;
public int Score = 0;
public int PowerUp = 10;
public int ArmorPowerUp = 20;
public int PlayerArmorStats = 0;


//This is basically functions that perform SIMPLE math operations based on int and other variables
//You can have the values of these variables change based on the functions you make or have them only reference them 


	void Start () 
	{
		//1
		if (A + B == C)
		{
			print(C);
		}
		//2
		if(A * B == C)
		{
			print(B);
		}
		//3
		if(A <= 0)
		{
			//Increments by 1
			A++;
		}
		//4
		if(A >= 10)
		{
			//Decrements by 1
			A--;
		}
		//5
		if(A/B)
		{
			print(Score);
		}
		//6
		//After these functions run, they will replace the current value of the int above with the new result based on these fucntions

		C + A + B;
		C += A + B;
		C -= A - B;

		//7
		//The resule of this equation will be 14 because C# follows the order of operations like in math class
		Console.WriteLine(6 + 2 * 4);
		Console.ReadLine();

		//8
		//If you want to force the equation to run the addittion before the multiplication, the (just like real math), put them in brackets
		Console.WriteLine((6 + 2) * 4);
		Console.ReadLine();

		//9
		Console.WriteLine(5 <= 2);
		//The console will return this as a "false" statement because 5 is indeed not less than or equal to 2

		//10
		if(PlayerArmorStats + ArmorPowerUp)
		{
			print("You picked up armor +20");
		}





		
	}





		
	
	
	void Update () {
		
	}
}

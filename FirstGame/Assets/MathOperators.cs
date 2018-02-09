using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperters : MonoBehaviour 
{


public int A = 10;
public int B = 10;
public int C = 10;
public int Score = 0;
public int PowerUp = 10;


//This is basically functions that perform SIMPLE math operations based on int and other variables
//


	void Start () 
	{
		if (A + B == C)
		{
			print(C);
		}

		if(A * B == C)
		{
			print(B);
		}

		if(A <= 0)
		{
			//Increments by 1
			A++;
		}

		if(A >= 10)
		{
			//Decrements by 1
			A--;
		}

		C + A + B;
		C += A + B;
		C -= A - B;

		
	}





		
	
	
	void Update () {
		
	}
}

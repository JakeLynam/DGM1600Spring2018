using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Lists are like arrays, except they are used when you don't know how many elements you are going to have in that container of data
*/

public class Lists : MonoBehaviour 
{

	public static void Main (string[] args)		//this is a method called "Main". It is called when the program starts.
	{
		//arrays - WUHUU!!!

		int[] numbers = new int[5];
		numbers[0] = 12;
		numbers[1] = 3;
		numbers[2] = 5;

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.Write (numbers[i])+;
		}

		foreach (int number in numbers)
		{
			Console.Write (number + );
			
		}


		Console.ReadKey ();
	}

		void Start () 
	{
		List<BadGuy> badguys = new List<BadGuy> ();

		badguys.Add( new BadGuy("William, 50"));
		badguys.Add( new BadGuy("Steve, 100"));
		badguys.Add( new BadGuy("Joe, 5"));


		
	}


	

	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour {

	public string [] PlayerNames;
	public string [] LevelZoneNames;
	public int [] PlayerScore;
	public int [] Enemies

/*
The foreach loop runs through an array, item by item, until it has reached the end
You cannot modify the elements of an array using a for each loop, you would have to use a for loop
 */
	
	void Start () 
	{
		string [] strings = weapoNnames[4]

		//1
		foreach (string item in strings)
		{
			print(weapon);
		}

		//2
		//this is the inefficient way to do a loop 
		//You have to manually input the code and data into the code itself instead of just using the unity inspector
		print(Player);
		{
			//numerically speaking, if you're counting up, you start at 0 and work your way up
			// example: 0
			print(Players[0]);
			print(Players[1]);
			print(Players[2]);
			print(Players[3]);
			print(Players[4]);
		}

		//3
		foreach (string zone in LevelZoneNames)
		{
			print(zone);
		}

		//4
		foreach (int score in PlayerScore)
		{
			print(score);
		}

		//5
		foreach (int number in Enemies)
		{
			print(number);
		}

		//6
		foreach (string player in Players)
		{
			print(player);
		}

		//7
		foreach (var score in HighScores)
		{
			if(score >= 1000)
			{
				print(score);
			}
		}
	}
	
}

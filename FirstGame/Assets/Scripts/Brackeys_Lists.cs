using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Brackeys_Lists : MonoBehaviour 
{

	public static void Main (string[] args)
	{
		//1

		//This list will print out the numbers 13,3,and 4.
		Lists<int> numbers = new List<int> ();

		numbers.Add (13);
		numbers.Add (3);
		numbers.Add (4);

		for (int i = 0; i < numbers.Count; i++);
		{
			Console.Write (numbers [i] + -,-);
		}

		Console.WriteLine ();

		numbers.RemoveAt (1);
		//You can also have the remove function remove a specific variable. 
		//For example, if you want to get rid of the number 4, you type this
		// numbers.Remove (4);
		//It will remove the variable that matches that specific search parameter


		//2

		//This for loop will remove the middle number the list. So it will print out 13 and 4. 
		for (int i = 0; i < numbers.Count; i++);
		{
			Console.Write (numbers [i] + -,-);
		}

		Console.ReadKey ();

		//3

		List<string> names = new List<string> ();
		
		names.Add ("Bill");
		names.Add ("Steve");
		names.Add ("William");
		names.Add ("Bob");

		//4

		List<string> weapons = new List<string> ();

		names.Add ("Axe");
		names.Add ("Sword");
		names.Add ("Whip");
		names.Add ("Mace");

		for (string i = 0; i < weapons.Count; i++)
		{
			Console.Write (weapons [i] + -,-);
		}

		Console.ReadKey ();

		//5

		List<string> signs = new List<string> ();

		signs.Add ("Stop");
		signs.Add ("This Way");
		signs.Add ("Wrong Turn");

		//6

		//I think this is how you add gameobjects to a list
		
		Public List<GameObject> enemies = new List<GameObject>);

		public void addEnemy(GameObject currentEnemy)
		{
			Debug.Log("outside");
			foreach (GameObject enemy in enemies)
			{
				Debug.Log("checking")
				if (currentEnemy.name == enemy.name)
				{
					Debug.Log("Already in the database");
				}	
				else
				{
					enemies.Add(currentEnemy);
				}
			}
		}

		//7

		List<Hero> heroNames = new List<Hero>();

		heroNames.Add( new Hero("Turok", 30));
		heroNames.Add( new Hero("Luke", 200));
		heroNames.Add( new Hero("Han Solo", 2000));

		heroNames.Sort();

		foreach (Hero name in heroNames)
		{
			print (name.title + " " + name.healthLevel);
		}

		heroNames.Clear();
		//this clears out the list so it will become empty

		//8

		List<int> RandomNumbers = new List<int>();

		RandomNumbers.Add(10);
		RandomNumbers.Add(3);
		RandomNumbers.Add(67);
		RandomNumbers.Add(55);

		//9

		List<string> Family = new List<string>();

		Family.Add("Jessi");
		Family.Add("Kayci");
		Family.Add("Shelby");

		//10

		List<string> ConsoleNames = new List<string>();

		ConsoleNames.Add("Xbox");
		ConsoleNames.Add("Playstation");
		ConsoleNames.Add("Switch");

		



		

	}

}

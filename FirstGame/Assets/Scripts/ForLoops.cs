using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour 
{
	

	int InventorySlots = 10;
	int enemies = 100;
	int allies = 20;
	int NPCcharacters = 5;
	int objectsAllowed = 100;
	int pickups = 10;
	int healthitems = 29;
	int armorPieces = 9;
	int PlayerStats = 190;
	int EnemyLife = 100;

	void Start()
	{
		//1
		//i++ increases the variable by 1
		for (int i = 0; i < InventorySlots; i++)
		{
			Debug.Log("Scanning inventory slots:" +i);
		}

		//2
		for (int i = 0; i < enemies; i++)
		{
			Debug.Log("Counting enemies on the battlefield: " + i);
		}

		//3
		for (int i = 0; i < allies; i++)
		{
			Debug.Log("How many allies do we have: " + i);
		}

		//4
		for (int i = 0; i < NPCcharacters; i++)
		{
			Debug.Log("Number of NPCs' here: " + i);
		}

		//5
		for (int i = 0; i < objectsAllowed; i++)
		{
			Debug.Log("Available amount of objects: " + i);
		}

		//6
		for (int i = 0; i < pickups; i++)
		{
			Debug.Log("Remaining pickups left: " + i);
		}

		//7
		for (int i = 0; i < armorPieces; i++)
		{
			Debug.Log("Armor pieces remaining: " + i);
		}

		//8
		for (int i = 0; i < PlayerStats; i++)
		{
			Debug.Log("Power level: " + i);
		}
		
		//9
		for (int i = 0; i < healthitems; i++)
		{
			Debug.Log("How many health potions: " + i);
		}

		//10
		for (int i = 0; i < EnemyLife; i++)
		{
			Debug.Log("How many more hits: " + i);
		}
	}

}

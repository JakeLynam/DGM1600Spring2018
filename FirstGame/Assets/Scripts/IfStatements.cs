using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

public class Inventory
{
	public int grenades;
	public int rockets;
	public int bullets;
	public int throwingknives;
	public int healthpacks;

	public Inventory ()
	{
	public float ArmorRating = 100;
	public float HealthRating = 100;
	public float healthpacks = 25;
	}
}

/*
If statements are functions that make a decision based on the meeting of a condition
If a certain thing happens that satisfies or meets the criteria of the if statement, then the if statement will perform it's role. 
 */

 	void Update ()
	 {
		 if(Input.GetKeyDown(KeyCode.Space))
		 {
			 print("Hello")
		 }

		 if(Input.GetKeyDown(KeyCode.b))
		 {
			 print("I pushed the b key :D ")
		 }
		 if (Input.GetKeyDown(KeyCode.shift))
		 {
			 print ("I shifted the button thingy!");

		 }

		 if(Input.GetKeyDown(KeyCode.h))
		 {
			 print("I like pushing the buttons!")
		 }
	 }



	
	void PlayerArmorStatus ()
	{
		if(ArmorRating = 0)
		{
			print ("Armor broken!");
		}
	}

	void PlayerVitality()
	{
		if(HealthRating = 0)
		{
			print ("You have died!");
		}
// if the first part of the if statement is not satified, then you can have the other outcome(s) perform a function
//For example, if your halth rating isnt at 0 but it is below 25, then you can have the game say the following
		else if (HealthRating < 25)
		{
			print ("Health critiquely low!");
		}
	}

	void PlayerAmmoCapacity ()
	{
		if (bullets = 200)
		{
			print ("Amma full");
		}
		else (bullets = 0)
		{
			print ("Out of ammo!");
		}
	}

	void PlayerGrenadeCapacity ()
	{
		if (grenades = 0)
		{
			print("No grenades");
		}
		else if (grenades = 4)
		{
			print ("Grenade capacity full");
		}
	}

	void PlayerKnifeCapacity ()
	{
		if (throwingknives = 0)
		{
			print ("Out of throwing knives");
		}
		else if (throwingknives = 4)
		{
			print ("Throwing knives full");
		}
	}

	void HealthPackFunction ()
	{
		if (healthpacks + HealthRating)
		{
			print ("Picked up health");
		}
	}

	








}

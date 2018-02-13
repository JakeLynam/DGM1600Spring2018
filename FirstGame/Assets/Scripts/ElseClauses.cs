using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClauses : MonoBehaviour {

	public 

	public float ManaPotionAmount = 50;
	public float HealthPotionAmount = 25;
	public float StaminaPotionAmount = 30;
	public float ArmorRepairKitAmount = 25;
	public float PlayerHealthAmount = 200;
	public float PlayerArmorBaseAmount = 200;
	public float PlayerStaminaAmount = 100;
	public float PlayerMagicAmount = 90;
	public float PlayerCurrencyAmount = 100;
	public float PlayerDeath = 1;

/*
The if else statement is an extention of the regular if statement
The if else statement comes into play when the condition of the if statement is not met
You can have as many else clauses as there are possible outcomes of a certain variable. 

 */
 	void Update ()
	 {

	 }

	
	void PlayerVitalityStatus () 
	{
		if(PlayerHealthAmount = 25)
		{
			print ("Health is low you fool!!!! Pick up a medkit!");
		}
		else if(PlayerHealthAmount < PlayerDeath)
		{
			print ("You are dead!");
		}
		else 
		{
			print("Health is ok");
		}
	}

	void PlayerArmorStatus ()
	{
		if(PlayerArmorBaseAmount < 25)
		{
			print ("Armor is about to break");
		}
		else if(PlayerArmorBaseAmount < 1)
		{
			print("Armor is broken");
		}
		else 
		{
			print("Armor is fine");
		}
	}

	void PlayerCurrencyStatus ()
	{
		if(PlayerCurrencyAmount < 10)
		{
			print ("low on funds");
		}
		else if(PlayerCurrencyAmount < 1)
		{
			print("Your broke fool, how you gonna take out that girl now!?!?");
		}
		else
		{
			print("Financial situation normal i guess....");
		}
	}

	void PlayerMagicStatus ()
	{
		if(PlayerMagicAmount = 100)
		{
			print("Mana full");
		}
		else if(PlayerMagicAmount < 25)
		{
			print("Mana low");
		}
		else if(PlayerMagicAmount < 1)
		{
			print("Out of mana");
		}
		else
		{
			print("Mana is good");
		}
	}

	void PlayerStaminaStatus ()
	{
		if(PlayerStaminaAmount = 100)
		{
			print("Stamina full");
		}
		else if(PlayerStaminaAmount < 50)
		{
			print("Running low on stamina");
		}
		else if(PlayerStaminaAmount < 1)
		{
			print("Out of stamina, take a breather before you kill yourself!");
		}
		else
		{
			print("You must eat your Wheaties!");
		}
	}

	void StartMenu ()
	{
		if(Input.GetKeyDown(KeyCode.S))
		{
			print("So i guess you wanna play?");

		}
		else 
		{
			print("Thats not the Start button you imbecile!!!!");
		}
	}







}

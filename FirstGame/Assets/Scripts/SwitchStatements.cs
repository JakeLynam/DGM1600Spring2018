using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour 
{
	public string username;
	public enum Color { Red, Green, Blue }
	public string PlayerName;
	

	//the fastest code in your game is the one that never runs
	//Switch statements are used when you want to compare a single variable to a series or list of constants
	//


	
	void Start () 
	{
		switch (username)
		{
			
			case "password":
				//do work
				print("Password is correct");

				break;

			case "LevelUp":
				//do work
				print("Next Level");
				break;

				//default is a better and some would say more efficient version of the "else" statement

				default:
				//do work
				print("why dont you just tell me which movie you want to see");
				break;

				//2

				public static void Main ()
				{
					Color c = (Color) (new Random()).Next(0, 3);
					switch (c)
					{
						case Color.Red:
							Console.WriteLine("Red");
							break;

						case Color.Green:
							Console.WriteLine("Green");
							break;

						case Color.Blue:
							Console.WriteLine("Blue");
							break;
					}
				}

				//3

				public static void Main ()
				{
					switch (PlayerName)
					{
						case "Enter Player Name":
						print ("Player 1"
						break;
					}
				}

				//4 

				//for a game like Fallout, the higher your intelligence level, the more sophistaced and smart you sound
				//This is a script for what your character will say based on their intellect level
				public static void Main ()
				{
						public int Intelligence = 5;

						void Greet ()

						switch (Intelligence)
						{
							case 5:
								print ("Hello my good man! Tis a jolly day!");
								break;

							case 3:
								print ("Ummmm..... hello");
								break;

							case 1:
								print ("uuuuhhhhhhh");
								break;
						}

						//5

						public int Armor = 3;

						void TestArmor ()
						{
							switch (Armor)
							{
								case 3:
									print ("Tis but a scratch!");
									break;

								case 2:
									print ("Ok, that kind of hurt");
									break;

								case 1:
									print ("My spleen!");
									break;
							}
						}

						//6

						public int Intmidation = 10;

						void JerkAround ()
						{
							switch (Intmidation)
							{
								case 10:
									print ("What cha lookin at punk!?");
									break;

								case 5:
									print ("Uhhh hey.... dont look at me.");
									break;

								case 1:
									print ("Dont hurt me!!!");
									break;

							}

							//7

							public int Romance = 10;

							void Swoon ()
							{
								switch (Romance)
								{
									case 10:
									print ("hey baby, i got a bucket of chicken");
									break;

									case 6:
									print ("Hey toots!");
									break;

									case 2:
									print ("You're just as pretty as my mom");
									break;


								}
							}

							//8 

							public int WitcherManipulation = 5;

							void Hypnotize ()
							{
								switch (WitcherManipulation)
								{
									case 5:
									print ("You hypnotized the character");
									break;

									case 4:
									print ("You hypnotized the character, but his friend saw you do it");
									break;

									case 1:
									print ("You failed to hypnotize");
									break;


								}
							}

							//9

							public int AgeLimit = 17;

							void AgeTest ()
							{
								switch (AgeLimit)
								{
									case 17: 
									print ("age accepted");
									break;

									default:
									print ("Age not accepted");
									break;
								}
							}

							//10

							public int HitSuccess = 20;

							void HitChance ()
							{
								switch (HitSuccess)
								{
									case 20:
									print ("You hit");
									break;

									default:
									print ("You missed");
									break;
								}
							}

						}
				}



		}
	}
	
	
	
	}
}

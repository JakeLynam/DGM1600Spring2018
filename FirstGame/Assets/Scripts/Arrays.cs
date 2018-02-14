using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour 
{

	//Arrays are used for storing data of the same type together(So ints go into an int array, strings go into a string array and so on)
	
	int[] EnemyAmount = new int[8];
	//2 the amount you can put into the array is made by how many elements you put into it
	int[] CoinPurseValue = {12, 4, 67, 45, 34};
	//3
	//if you make the array public, youll be able to see it in the unity inspector and edit the values in it or add/subtract values
	public GameObject[] players; 
	//4
	public GameObject[] weapons;
	//5
	public GameObject[] armorPieces;
	//6
	public GameObject[] mounts;
	//7
	public string[] CatNames;
	//8
	public string[] DogNames;
	//9
	public int[] MyNumbers;
	//10
	public GameObject[] vehicles;


	
	void Start () 
	//1
	//This is an ineffective way of calling an array
	{
		EnemyAmount[0] = 12;
		EnemyAmount[1] = 3;
		EnemyAmount[2] = 3;
		EnemyAmount[3] = 7;
		EnemyAmount[4] = 7;
		EnemyAmount[5] = 5;
		EnemyAmount[6] = 90;
		EnemyAmount[7] = 87;
		EnemyAmount[8] = 54;
	
	}

	void Start()
	//2
	//a better way of calling an array, you can call it while you declare it
	{
		CoinPurseValue[5] = 34
	}

	void Start ()
	//4
	//This will search the weapons array and return every game object with tag weapon
	{
		weapons = GameObject.FindGameObjectWithTag("Weapon")
	}


	
	


}

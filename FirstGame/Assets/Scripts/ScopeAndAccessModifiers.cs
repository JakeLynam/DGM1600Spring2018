using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour 
{

	//the scope of a variable is the area in the code that the variable can be used in
	//usually curly braces are what the scope is for a variable
	//access modifiers allow code to be seen and accessed from, public means that other scripts can access it, private means it cannot
	//If something is public, then it can be accessed outside of the class

	public Rigidbody rb;

	//1
	public int Player1 = 2;

	//2
	public int Player2 = 23;

	//3
	private int Player3 = 44;

	//4
	//if you place the variable inside of a function like Start and Awake, the Unity inspector cannot overide it

	void Update ()
	{
		public int Player4 = 44;
	}
	//5
	void fixedupdate ()
	{
		rb.AddForce(0, 0, 200 * Time.deltaTime); 
		
	}

	//6
	void Weapons(string swords, string mace)
	{
		string answer;
		answer = swords, mace;
		Debug.Log(answer);
	}

	//7

	public int Health = 10;

	void Update()
	{
		Debug.Log(Health);	
	}

	//8

	private string Myname = "Timmy";

	void Update()
	{
		Debug.Log("That is your name, good job!");
		
	}

	//9

	public float forwardForce = 3000;

	void FixedUpdate()
	{
		rb.AddForce(0, forwardForce, 0);
	}

	//10

	public float ArmorRating = 100;

	void Update()
	{
		Debug.Log(ArmorRating);
	}






	

	
}

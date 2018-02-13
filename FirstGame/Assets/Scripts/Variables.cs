using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Variables : MonoBehaviour {

/*
Variables are storage locations with values that can be edited
These things can be added to game objects like characters models, 3d objects, ect.
Here, I'm going to make a Public string, it's public so it can be accessed by other codes and can be seen in Unity's inspector
*/
	string Mystring Jake;
	int myInt = 5;
	string Character1Name = Steve;
	int LifeTotal = 100;
	int ArmorTotal = 100;
	

// this variable is a place where I have put my name, but it has my name because it's grabbing the info from a string
//Thus, the answer for "My name is..." can change according to what string you want to call to

	void Start () 
	{
		Debug.log("My name is" + Jake);
	}
//Some types of variables are local variables, parmameters, fields, or array elements. 	
	
	Void Update ()
	{
		Debug.Log (myInt * 2);
	}
























}

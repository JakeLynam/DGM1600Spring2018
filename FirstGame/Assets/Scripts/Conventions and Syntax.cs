using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
/*
If blocks of code are like boxes, then the NewBehaviourScript is the name or identifier of this class
Everything onward is inside this class
Things inside this box cant access things outside this box, but things outside can access things inside this box
*/

	
	void Start () 
	{
		
	}
	
	
	void OnMouseDown () 
	{
		print ("Wa-hoo");
		print ("Mario has jumped")
		
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			Debug.Log
	}

	Void OnMouseDown()

	{
		print("Do a little dance");
	}

	void OnMouseUP()
	{
		prin ("Why you mouse up?");
	}

	Void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		Debug.Log("F key was pressed");

		if (Input.GetKeyUp(KeyCode.F))
		Debug.Log("F key was released");
	}











}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsRedo : MonoBehaviour {

	
	void Start () 
	{
		
	}
	
	
	void Update () 
	{
		if(input.GetKeyDown(KeyCode.R))
		{
			gameObject.renderer.material.color = Color.red;
		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour 
[CreateAssetMenu]

{
	public int PowerLevel = 9000;
	public Player CurrentPlayer;

	public void RunPowerUp()

	{
		//Adds value 
		CurrentPlayer.Score += PowerLevel;
		
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour 
{


//functions do things with other boxes of codes like variables and give information back
//code that starts with the phrase "void" do not return anything

int health = 10;
int Armor = 10;
int Magic = 30;

void Start()
{
	//this is calling my function "addHealth" 
	health = addHealth(health);
	Debug.Log (health);

	Armor = addArmor(Armor);
	Debug.Log (Armor);

	Magic = addMagic(Magic);
	Debug.Log (Magic);





}
//1

//int = the type of function: addHealth = the function name: int = type of paramter: medpack = parameter name
int addHealth(int medpack)
{
	int ret;

	ret = number * 2;

	return ret; 
}

//2

int addArmor(int RepairKit)
{
	int _RepairKit;

	_RepairKit = RepairKit * 3;

	return _RepairKit;
}

//3

int addMagic(int MagicPotion)
{
	int _addMagic;

	_addMagic = MagicPotion * 2;

	return _addMagic;

}

//4

string DisplayName(string Name)
{
	string _displayname;

	_displayname = Name;

	return _displayname;
}

//5

string ShowPlayerName(string PlayerName)
{
	string _displayname;

	_displayname = PlayerName;

	return _displayname;
}

//6

void Update()
{
	if (Input.GetKeyDown(KeyCode.Space))
	{
		PlayerPosition(this.gameObject);	
	}
}

GameObject PlayerPosition(GameObject Player)
{
	Debug.Log("Position: " + Player.transform.position);
	
}

//7

public int A = 3;
public int B = 5;

void Update()
{
	if (Input.GetKeyDown(KeyCode.F))
	{
		total = AdditionTest(A, B)
		Debug.Log("Total:" + total);
	}
}

public int AdditionTest(int A, int B)
{
	return A + B;
}

//8

public GameObject sphere;

void Update()
{
	if (Input.GetKeyDown(KeyCode.Space))
	{
		sphere.GetComponent<Renderer>().material.color = ChangeColor(Color.blue);
	}
}

Color ChangeColor(Color newColor)
{
	return newColor;
}

//9

public GameObject cube;

void Update()
{
	if (Input.GetKeyDown(KeyCode.Y))
	{
		cube.GetComponent<Renderer>().material.color = SwitchColor(Color.yellow)
	}
}

Color SwitchColor(Color newColor)
{
	return newColor;
}

//10

public GameObject Obstacle;

void Update()
{
	if (Input.GetKeyDown(KeyCode.G))
	{
		Obstacle.GetComponent<Renderer>().material.color = DifferentColor(Color.green)
	}
}

Color DifferentColor(Color newColor)
{
	return newColor;
}
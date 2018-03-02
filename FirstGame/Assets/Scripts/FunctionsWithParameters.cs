using System.Collections;
using System.Collections.Generic;
using UnityEngine;

{}
public class FunctionsWithParameters : MonoBehaviour 
{
	public class Pool
	{
		public string tag;
		public GameObject prefab;
		public int size;
	}

	public int health = 20;
	public GameObject projectile;
	public GameObject Box;
	public GameObject Wall;
	
	public Dictionary<string, Queue<GameObject>> poolDictionary; 
	public List<pool> pools;





	//1

	void OnTriggerEnter(Collider other)
	{
		print("hit something");
		print(other);
		


		//if you want to add more numbers into the function, you add a comma, then the desired number

		AddNumbers(14, 2)
	}

	//2

	void AddNumbers(int a)
	{
		print(a += 10);
	}
	
	//3

	void PlayerData(string name)
	{
		print("Bob")
	}

	//4

	void AddHealth(int newHealth)
	{
		health += newHealth;
	}

	//5

	void OnTriggerEnter(Collider Box)
	{
		Destroy(Box.GameObject);
	}

	//6

	void OnTriggerEnter(Collider Wall)
	{
		Destroy(Wall.GameObject)
	}

	//you can have the player throw a grenade and you can have a prefab explosion when it hits a surface and then destroys itself
	//7

	public Transform explodionPrefab;
	void OnCollisionEnter(Collision collision)
	{
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		Instantiate(explodionPrefab, pos, rot);
		Destroy(gameObject);
	}

	//This is an example of object pooling (spawning objects really fast but also gets rid of them so their isnt alot of processing power needed)

	//8

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider == true)
		{
			coll.collider.enabled = false;
		}
	}




	//9

	void OnTriggerEnter(Collider something)
	{
		print("I hit another something");
		print(something);
		
	}


	//This next one is using a raycast method that will collide/hit an object that has a 2D collider

	//10

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{	
			//Vector2 represents the vectors and points in a 2D space

			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RayCastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

			if (hit.collider != null)
			{
				Debug.Log(hit.collider.name);
			}
		}
	}



}

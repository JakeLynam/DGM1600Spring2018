using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

public string password = "love";
public int A;
public int B;
public int C;
public int a = 1;
public int b = 2;
public int c = 3;
public string password2 = "YaBaby";
public string SecretLevel = "The cow level";


//logic is where functions return answers or results based on the information that is being called and put into the variable
/*Like a function that asks what the password is, you can declare the variable in a string, then if the variable calling for 
it gets the string name right, then the function can continue to prove the answer is correct and do what it supposed to do
in these functions, you can even force the original variable to change
*/
	
	void Start () 
	{
		//1
		if (A > B && password == "love")
		{
			print("Password is correct");
		}

		//2
		Debug.Log (a * 2);

		//3
		if (a + b)
		{
			print("Your answer is")
		}


	}

	void Start ()
	{
		MultiplyByThree(a);
		b = MultiplyByFour(b);
		//5 here we can use Debug.Log to see our value in the console window
		Debug.Log(b);
	}

	//4
	//Here we are going to perfom a function where we'll call for something to be times by 3, then we'll get a return/result
	int MultiplyByThree(int number)
	{
		int ret;

		ret = number *3;

		return ret;
		//Your ret or "return" will be the result of timesing int a by 3, which will be 3
	}

	//5 
	//We can a similar thing but we can change the declared value of a variable in the function itself
	//Even though the value of b is 2, we can change its value in the floating int before the start function after the function runs


	int MultiplyByFour(int number)
	{
		int ret;

		ret = number * 4;

		return ret;
	}

	//6
	//This will return a value for C even if there is no value set in the floating statement
	void start()
	{
		int C = 15;
	}

	//7
	void MyNameIs()
	{
		if(a > c)
		{
			Console.WriteLine("Jake")
		}

	}

	//8
	void PasswordBox()
	{
		if(password2 == "YaBaby")
		{
			Console.WriteLine("Password is correct")
		}

	}

	//9
	void PasswordBox2()
	{
		if(password2 == "YaBaby"||"yababy")
		{
			Console.WriteLine("Password is good to go")
		}
		else
		{
			Console.WriteLine("Password Incorrect")
		}
	}

	//10
	void CowLevelQuestion()
	{
		if(string == "The Cow Level" || "the cow level")
		{
			print("Correct");
		}
		else
		{
			print("no today my good sir");
		}
	} 

	

	
	
	void Update () {
		
	}
}

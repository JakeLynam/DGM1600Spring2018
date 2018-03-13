using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMotor : MonoBehaviour 
{
[SerializeField]
private Camera cam; 
//cannot name this camera "camera" because that is already a member in MonoBehaviour

//The "PlayerController" script controls the variable "velocity" in this script
private Vector3 velocity = Vector3.zero;
private Vector3 rotation = Vector3.zero;
private Vector3 cameraRotation = Vector3.zero;


private Rigidbody rb;

void Start()
{
	rb = GetComponent<Rigidbody>();
}

//Gets a movement vector
public void Move (Vector3 _velocity)
{
	velocity = _velocity;
}

//Gets a rotational vector
public void Rotate (Vector3 _rotation)
{
	rotation = _rotation;
}

//Gets a rotational vector for the camera
public void RotateCamera (Vector3 _cameraRotation)
{
	cameraRotation = _cameraRotation;
}

//Runs every physics iteration
void FixedUpdate()
{
	PerformMovement();
	PerformRotation();
}

//perform movement based on "velocity" variable
void PerformMovement()
{
	if (velocity != Vector3.zero)
	{
		//this will move our rigidbody (our player) to the position of our player?
		rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	}
}

//Perform rotation
void PerformRotation()
{
	//rb.rotation is a Quaternion, and Quaternion.Euler will take our Vector3 called "rotation" and turn it into a Quaternion
	rb.MoveRotation(rb.rotation * Quaternion.Euler (rotation));
	if (cam != null)
	{
		//putting a - sign in front of "cameraRotation" will make the controls regular and not inverted on the y-axis
		cam.transform.Rotate(-cameraRotation);
	}
}



}

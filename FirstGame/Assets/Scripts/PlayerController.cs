using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float lookSensitivity = 3f;

	private PlayerMotor motor;

	void Start()
	{
		motor = GetComponent<PlayerMotor>();
	}

	void Update()
	{
		//calculate our movement velocity as a 3D vector
		
		//"GetAxisRaw" is better than using "GetAxis" because unity does more processing on "GetAxis", but we have full control with the other

		float _xMov = Input.GetAxisRaw("Horizontal"); //Horizntal goes between -1 and 1
		float _zMov = Input.GetAxisRaw("Vertical");	  //Vertical goes between -1 and 1

		//Use "transfrom.right" instead of "Vector3.right" because "transform.right" is local and not about the object's global orientation
		Vector3 _movHorizontal = transform.right * _xMov; 
		Vector3 _movVertical = transform.forward * _zMov; 

		//"normalized" means it will take the _movHorizontal + _movVertical and make them both equal to one instead of varying decimals???

		//Final movement Vector
		Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed; 

		//Apply movement
		motor.Move(_velocity);

		//Calculate rotation as a 3D vector
		//Mouse x calculates movement for looking left or right (turing around)
		float _yRot = Input.GetAxisRaw("Mouse X");

		Vector3 _rotation = new Vector3 (0, _yRot, 0) * lookSensitivity;

		//Apply rotation
		motor.Rotate(_rotation);

		//Calculate camera rotation as a 3D vector
		float _xRot = Input.GetAxisRaw("Mouse Y");

		Vector3 _cameraRotation = new Vector3 (_xRot, 0, 0) * lookSensitivity;

		//Apply rotation
		motor.RotateCamera(_cameraRotation);
		
		
	}
}

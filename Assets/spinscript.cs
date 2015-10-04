using UnityEngine;
using System.Collections;
//http://answers.unity3d.com/questions/952577/advanced-rotation-on-2d-circle-with-mouse-drag.html
public class spinscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	/// <summary>
	/// The speed.
	/// </summary>
	public float speed = 10f;
	/// <summary>
	/// The mouse x.
	/// </summary>
	public float mouseX;
	private float xDeg;
	private float yDeg;

	private Quaternion fromRotation;
	private Quaternion toRotation;

	void FixedUpdate  () {

		if (Input.GetMouseButton (0)) {
			GetComponent<Rigidbody2D>().angularVelocity = 10; 
		}

		
		/*
		if (Input.GetMouseButton(0))
		{		
				float x = -Input.GetAxis("Mouse X");
				float y = -Input.GetAxis("Mouse Y");
			Vector2 velocity = new Vector2(x,y);
			speed =	velocity.magnitude;	
				transform.Rotate(new Vector3(0,0,speed));*/



		/*if(Input.GetMouseButton(0)) {
			Vector3 mouse_position = Input.mousePosition;
			float x =  mouse_position.x;
			print (x);
			float y = mouse_position.y;

			xDeg -= Input.GetAxis("Mouse X") * speed ;
			yDeg += Input.GetAxis("Mouse Y") * speed ;

			if (x<Screen.height/2) {
				xDeg = -xDeg;
			}
			//if (y<Screen.width/2) {
			//	yDeg = -yDeg;
			//}

			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler(0,0,xDeg);
			transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.time * speed);
		}*/
		}
	}

	/*
	void Update(){
	
		//Get how far the mouse has moved by using the Input.GetAxis().
		float rotationX= Input.GetAxis("Mouse X") ;
		float rotationY = Input.GetAxis("Mouse Y");
		
		//Rotate the object around the camera's "up" axis, and the camera's "right" axis.
		transform.RotateAroundLocal(new Vector3(0,1,0)        , -Mathf.Deg2Rad * rotationX );
		//transform.RotateAroundLocal(       ,  Mathf.Deg2Rad * rotationY );

	}*/


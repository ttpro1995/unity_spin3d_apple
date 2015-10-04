using UnityEngine;
using System.Collections;

public class MouseVelocity : MonoBehaviour {

	private Vector3 lastPos;
	private Vector3 delta;
	private float distance;
	private float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if ( Input.GetMouseButtonDown(0) )
		{
			lastPos = Input.mousePosition;
		}
		else if ( Input.GetMouseButton(0) )
		{
			//delta = Input.mousePosition - lastPos;
			
			// Do Stuff here
			
			//Debug.Log( "delta X : " + delta.x );
			//Debug.Log( "delta Y : " + delta.y );
			distance = Vector3.Distance(Input.mousePosition,lastPos);
			speed = distance / Time.deltaTime;
			Debug.Log("speed = "+speed);
			
			// End do stuff
			
			lastPos = Input.mousePosition;
		}
	}

}

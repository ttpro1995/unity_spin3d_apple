using UnityEngine;
using System.Collections;
//http://answers.unity3d.com/questions/952577/advanced-rotation-on-2d-circle-with-mouse-drag.html
public class dragscript : MonoBehaviour {

	private Vector3 SpinnerScreenPoint;
	private Vector3 GesturePoint;
	private float RotationAngle;
	// Use this for initialization
	void Start () {
	
	}
	


	public void On_Drag(Vector3 mouseposition)
	{

			 SpinnerScreenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		GesturePoint.x = mouseposition.x;
		GesturePoint.y = mouseposition.y;
			SpinnerScreenPoint = (GesturePoint - SpinnerScreenPoint);
			RotationAngle = (Mathf.Atan2(SpinnerScreenPoint.y, SpinnerScreenPoint.x) * Mathf.Rad2Deg - 90);

		//float newRot = Mathf.Atan2(SpinnerScreenPoint.y, SpinnerScreenPoint.x) * Mathf.Rad2Deg - 90;
//		RotationAngle = OriginalRotAng + newRot - OriginalTouchAng;
	}
	
	void Update()
	{
		if (Input.GetMouseButton (0)) {
			On_Drag(Input.mousePosition);
			gameObject.transform.rotation = Quaternion.AngleAxis (RotationAngle, Vector3.forward);
		}
	}
}

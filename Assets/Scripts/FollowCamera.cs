using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public GameObject target;
	Vector3 offset;
	public float damping = 1;

	// Use this for initialization
	void Start () {
		offset = target.transform.position - transform.position;	
	}
	
	// // Update is called once per frame
	// void Update () {
		
	// }

	
	void LateUpdate() {

		//To orient the camera behind the target, 
		//we first need to get the angle of the target and 
		//turn it into a rotation 
		float currentAngle = transform.eulerAngles.y;
		float desiredAngle = target.transform.eulerAngles.y;

		//Instead of lerping between two points like we did with the Dungeon camera, 
		//we'll be lerping between the angle of the camera and the angle of the 
		//target. So, rather than Vector3.Lerp(), 
		//we use the Mathf.LerpAngle() method. 
		float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
		Quaternion rotation = Quaternion.Euler(0, angle, 0);

		//We can then multiply the offset by the rotation to 
		//orient the offset the same as the target. 
		//We then subtract the result from the position of the target.
		transform.position = target.transform.position - (rotation * offset);

		//To keep looking at the player:
		transform.LookAt(target.transform);

	}
}

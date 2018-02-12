﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : MonoBehaviour {

	public GameObject target;
	Vector3 offset;
	public float damping = 1;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
		
	}
	
	// // Update is called once per frame
	// void Update () {
		
	// }

	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
		transform.position = position;

		transform.LookAt(target.transform.position);

	}
}

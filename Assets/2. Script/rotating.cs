using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour {
	
	public float speed = 50f;

	// Use this for initialization
	void Start () {
		
	}

	void Update ()
	{
		transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCube : MonoBehaviour {

	public GameObject mainCube;
	public Button[] buttons;

	float speed = 50;
	bool rotateFlag;

	private Renderer rndr;
	int count = 0;
	int maxCount = 5;

	// Use this for initialization
	void Start () {
		rotateFlag = false;
		rndr = mainCube.GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				// Create a particle if hit
			}
		}

		if (rotateFlag) {
			if (mainCube.activeSelf) {
				mainCube.GetComponent<Transform> ().Rotate (Vector3.left, speed * Time.deltaTime);
			}
		}
		
	}

	public void OnClickedRotate(){
		rotateFlag = true;
	}

	public void OnClickStop(){
		rotateFlag = false;
	}

	public void OnClickColor(){
		count++;
		switch (count % maxCount) 
		{
		case 0:
			rndr.material.color = Color.white;
			Debug.Log ("White");
			break;
		case 1:
			rndr.material.color = Color.red;
			Debug.Log ("Red");
			break;
		case 2:
			rndr.material.color = Color.blue;
			Debug.Log ("Blue");
			break;
		case 3:
			rndr.material.color = Color.green;
			Debug.Log ("Green");
			break;
		case 4:
			rndr.material.color = Color.cyan;
			Debug.Log ("Cyan");
			break;
		default:
			rndr.material.color = Color.white;
			Debug.Log ("White");
			break;	
		}

	}

	public void OnClickEffect(){

	}

}


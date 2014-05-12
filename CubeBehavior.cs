using UnityEngine;
using System.Collections;


public class CubeBehavior : ActionController {

	// Use this for initialization
	void Start () {
		//ConstForward (rigidbody, 2F);
		//Jump (rigidbody, 500);
		//transform.rotation = SpinX (transform, 40);
	}
	
	// Update is called once per frame
	void Update () {
		//MoveForward(transform, 2F, Time.deltaTime);
		//transform.rotation = SpinY (transform, 2);
		//rigidbody.velocity = new Vector3 (0, 0, 1);
		//transform.position = MoveEast(transform, 2F, Time.deltaTime);
		//transform.position = MoveRight (transform, 2F, Time.deltaTime);
		//Vector3 vec = new Vector3 (0, 1, 0);
		//transform.Rotate (vec, 2F);
		//transform.Translate (Vector3.forward * 2F * Time.deltaTime);
		//transform.position += Vector3.forward * 2F * Time.deltaTime;

		if (Input.GetKey (KeyCode.UpArrow)) {
			MoveForward(2, Time.deltaTime);		
		}if (Input.GetKey (KeyCode.LeftArrow)) {
			SpinY(-2);	
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			SpinY(2);	
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump(500);
		}
	}
}

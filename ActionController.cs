using UnityEngine;
using System.Collections;

public class ActionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Forward, Backward, Right, Left are in the body axis

	// Forward is relative to blue arrow axis
	public void MoveForward(float speed, float time){
		transform.Translate (Vector3.forward * speed * time);
	}

	public Vector3 MoveForward(Transform trans, float speed, float time){
		trans.Translate (Vector3.forward * speed * time);
		return trans.position;
	}

//	public void MoveForward (Rigidbody rigibody, float speed){
//		rigibody.velocity = new Vector3 (0F, 0F, speed);
//	}

	public void MoveBackward(float speed, float time){
		transform.Translate (Vector3.back * speed * time);
	}
	public Vector3 MoveBackward(Transform trans, float speed, float time){
		trans.Translate (Vector3.back * speed * time);
		return trans.position;
	}


//	public void MoveBackward (Rigidbody rigibody, float speed){
//		rigibody.velocity = new Vector3 (0F, 0F, -speed);
//	}

	// Right is positive red arrow
	public void MoveRight(float speed, float time){
		transform.Translate (Vector3.right * speed * time);
	}
	public Vector3 MoveRight(Transform trans, float speed, float deltime){
		trans.Translate (Vector3.right * speed * deltime);
		return trans.position;
	}

	public void MoveLeft(float speed, float time){
		transform.Translate (Vector3.left * speed * time);
	}
	public Vector3 MoveLeft(Transform trans, float speed, float deltime){
		trans.Translate (Vector3.left * speed * deltime);
		return trans.position;
	}

	// North is Positive Z (Blue) direction
	public void MoveNorth(float speed, float deltime){
		transform.position += Vector3.forward * speed * deltime;
	}
	public Vector3 MoveNorth(Transform trans, float speed, float deltime){
		trans.position += Vector3.forward * speed * deltime;
		return trans.position;
	}
	public void MoveSouth(float speed, float deltime){
		transform.position += Vector3.back * speed * deltime;
	}
	public Vector3 MoveSouth(Transform trans, float speed, float deltime){
		trans.position += Vector3.back * speed * deltime;
		return trans.position;
	}
	// East is positive X (red) direction
	public void MoveEast(float speed, float deltime){
		transform.position += Vector3.right * speed * deltime;
	}
	public Vector3 MoveEast(Transform trans, float speed, float deltime){
		trans.position += Vector3.right * speed * deltime;
		return trans.position;
	}
	public void MoveWest(float speed, float deltime){
		transform.position += Vector3.left * speed * deltime;
	}
	public Vector3 MoveWest(Transform trans, float speed, float deltime){
		trans.position += Vector3.left * speed * deltime;
		return trans.position;
	}

	// Jump function
	public void Jump (float force){
		rigidbody.AddForce (0F, force, 0F);
	}
	public void Jump (Rigidbody rbody, float force){
		rbody.AddForce (0F, force, 0F);
	}

	// Rotation
	public Quaternion SpinX (Transform trans, float angle){
		Vector3 x = new Vector3 (1, 0, 0);
		trans.Rotate (x, angle);
		return trans.rotation;
	}
	public void SpinX (float angle){
		Vector3 x = new Vector3 (1, 0, 0);
		transform.Rotate (x, angle);
	}

	// Spin clockwise (right) is positive angle
	public Quaternion SpinY (Transform trans, float angle){
		Vector3 y = new Vector3 (0, 1, 0);
		trans.Rotate (y, angle);
		return trans.rotation;
	}
	public void SpinY (float angle){
		Vector3 y = new Vector3 (0, 1, 0);
		transform.Rotate (y, angle);
	}

	public Quaternion SpinZ (Transform trans, float angle){
		Vector3 z = new Vector3 (0, 0, 1);
		trans.Rotate (z, angle);
		return trans.rotation;
	}
	public void SpinZ (float angle){
		Vector3 z = new Vector3 (0, 0, 1);
		transform.Rotate (z, angle);
	}




}

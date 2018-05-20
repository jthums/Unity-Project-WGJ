using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubespin : MonoBehaviour {
	Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		rb.AddTorque((Vector3.right + Vector3.up) * 60);
	}
}

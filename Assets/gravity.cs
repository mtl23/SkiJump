using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	public Rigidbody body;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		body.GetComponent<Rigidbody>().AddForce(0,-1,0);
	}
}

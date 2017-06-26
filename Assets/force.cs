using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		print ("push me");
		gameObject.GetComponent<Rigidbody>().AddForce(0,0,-50);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

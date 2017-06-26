using UnityEngine;
using System.Collections;

public class Camera_Still : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
	}
}

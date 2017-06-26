using UnityEngine;
using System.Collections;


/*
1.Collision dectection with the shpere and 2.adjust the points value
 */

public class ramp_addforce : MonoBehaviour {
	
	
	public GameObject barrel;
	
	void OnCollisionStay(Collision collision) {
		
		if (collision.gameObject.name  == "barrel") {
			
			Debug.Log ("speedup!!");
			barrel.GetComponent<Rigidbody>().AddForce(0,-2,-5);
	}
	
}
}
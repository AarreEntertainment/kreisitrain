using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour {

	// Use this for initialization
	public void Shake () {
        GetComponent<Animator>().SetTrigger("shake");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

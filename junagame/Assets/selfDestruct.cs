using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour {
    IEnumerator die()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
	// Use this for initialization
	void Start () {
        StartCoroutine(die());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

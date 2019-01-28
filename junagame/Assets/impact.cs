using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {
    public int index;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "obstacle")
        {
            
            transform.root.GetComponent<SpringJoint>().connectedBody = null;
            movement mov = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
            if (mov.numberOfCartsAttached > index) { 
            mov.numberOfCartsAttached = index;
                Camera.main.GetComponent<screenShake>().Shake();
                mov.lives.text = index.ToString();
                if (index == 0)
                    mov.end();
            }
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

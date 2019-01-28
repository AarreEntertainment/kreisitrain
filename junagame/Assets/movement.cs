using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public int score;
    public UnityEngine.UI.Text scorew;
    public UnityEngine.UI.Text lives;
   public  bool dead = false;
    public GameObject deathgui;
    public void end() {
        dead = true;
        deathgui.SetActive(true);
    }
    public IEnumerator addtoScore() {
        yield return new WaitForSeconds(1);
        if (!dead)
        {
            score += (1 * numberOfCartsAttached);
            scorew.text = score.ToString();
            StartCoroutine(addtoScore());
        }
        
     
    }
    public int numberOfCartsAttached;
    public float speed;
	// Use this for initialization
	void Start () {
       this.GetComponent<Rigidbody>().velocity = Vector3.forward * 30;
        StartCoroutine(addtoScore());
    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal")*speed;
        float y = Input.GetAxis("Vertical")*speed;

        transform.Translate(new Vector3(x*Time.deltaTime, y*Time.deltaTime, 0));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCreator : MonoBehaviour {
    public GameObject obstacle;
     float difficulty = 1;
    public IEnumerator difficultyAdjustment() {
        yield return new WaitForSeconds(1);
        difficulty -= 0.02f;
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dead)
            StartCoroutine(difficultyAdjustment());
    }
    // Use this for initialization
    void Start() {
        StartCoroutine(difficultyAdjustment());
        StartCoroutine(obstacleCreate());
    }
    public IEnumerator obstacleCreate(){
        yield return new WaitForSeconds(Random.value*difficulty);

        GameObject obs = Instantiate(obstacle);
        obs.transform.position = new Vector3(transform.position.x+(Random.value-0.5f)*30, transform.position.y+(Random.value - 0.5f) * 30, transform.position.z);
        if(!GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().dead)
        StartCoroutine(obstacleCreate());

    }
	// Update is called once per frame
	void Update () {
		
	}
}

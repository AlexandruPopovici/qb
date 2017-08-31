using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(1);
        GetComponent<Animator>().SetFloat("Speed", 1);
        yield return new WaitForSeconds(2);
        GetComponent<Animator>().SetFloat("Speed", 0);
        //GetComponent<Animator>().SetTrigger("Go");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

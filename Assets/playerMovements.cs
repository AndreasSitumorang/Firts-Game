using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovements : MonoBehaviour {
    Animator animE;
    // Use this for initialization
    void Start () {
        //anim = GetComponent<Animator>();
        animE = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            animE.SetBool("Lompat", true);
        }
        else animE.SetBool("Lompat", false);
    }
}

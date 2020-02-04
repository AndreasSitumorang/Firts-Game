using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerManagerrr : MonoBehaviour {

    [SerializeField]
    private float speed;

    public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);
    }

    // Use this for initialization
    
    
    
    /*void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}

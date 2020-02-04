using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsEsimu : MonoBehaviour {
    [SerializeField]
    private float speed;
    // Use this for initialization
    [SerializeField]
    private Transform neighbour;
    public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);
    }
    void Start () {
        transform.position = new Vector2(neighbour.position.x, transform.position.y);

    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Reset")
        {
            Destroy(gameObject);
        }
    }

}

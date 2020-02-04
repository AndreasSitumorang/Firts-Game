using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koino : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform neighbour;

    public void Mover()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);
    }

    public void SnapParentToNeighbour()
    {
        transform.position = new Vector2(neighbour.position.x, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Reset")
        {
            SnapParentToNeighbour();

        }
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Ninja : MonoBehaviour {

    Animator animE;
    public Rigidbody2D myRb { get; set; }
    private bool fly;
    [SerializeField]
    private float flyForce;

    public bool tanah;
    public LayerMask target;
    public Transform deteksiTAnah;
    public float jangkauan;

    [SerializeField]
    private GameObject head;
    private bool isDead;


    public int koin;
	// Use this for initialization
	void Start () {
        myRb = GetComponent<Rigidbody2D>();
        animE = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        tanah = Physics2D.OverlapCircle (deteksiTAnah.position, jangkauan, target);




        if (!EventSystem.current.IsPointerOverGameObject())
        {  if (Input.GetMouseButtonDown(0) && !Isdead)
            {
                fly = true;
                animE.SetBool("Lompat", true);
            }
        }
        if(tanah == true)
        {
            animE.SetBool("Lompat", false);
        }else if(tanah == false){
            animE.SetBool("Lompat", true);
        }
        
	}

    public bool Isdead
    {
        get
        {
            return isDead;
        }
       /*et
        {
            isDead = value;
        }*/
    }
    

   



    private void FixedUpdate()
    {
        if (fly)
        {

            myRb.velocity = Vector2.zero;
            myRb.AddForce(new Vector2(0,flyForce),ForceMode2D.Impulse);
            fly = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D cother)
    {
       // Debug.Log("cother");
       if(cother.tag == "Enemy")
        {
            //Destroy(gameObject);
            StartCoroutine(Enumerator());
        }
     }

    private IEnumerator Enumerator()
    {
    isDead = true;
    yield return new WaitForSeconds(1);
        Destroy(gameObject);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}

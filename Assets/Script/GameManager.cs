 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    // Use this for initialization
    private BackgroundElemets[] backgrounElemets;
    private Koino []point;

    [SerializeField]
    private Ninja ninja;

    //[SerializeField]

    bool lope = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!ninja.Isdead)
        {
            foreach (BackgroundElemets element in backgrounElemets )
            {
                element.Move();
            }
         }
        if(!ninja.Isdead )
        {
            foreach (Koino elemento in point)
            {
                elemento.Mover();
            }
        }
    }
}

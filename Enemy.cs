using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
     private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // anim.SetBool("Hurt", hit);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.name == "PLAYER")
        {
         }
    }
}

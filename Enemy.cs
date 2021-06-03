using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
     private Animator anim;
     public float enemySpeed;
     public GameObject _player;
     private SpriteRenderer rend;

     private EnemyTurnstate curState;
    private enum EnemyTurnstate
    {
        Waiting,
        Attacking
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

        curState = EnemyTurnstate.Waiting;
    }

    // Update is called once per frame
    void Update()
    { 
         switch (curState)
         {
             case(EnemyTurnstate.Attacking):
             break;

             case(EnemyTurnstate.Waiting):
             EnemyMove();
             break;
             
         }
        if(transform.position.x < _player.transform.position.x)
        {
            rend.flipX = true;
        }
        else if (transform.position.x > _player.transform.position.x)
        {
            rend.flipX = false;
        }
    
    }

    public void EnemyMove()
    {
        float step = enemySpeed * Time.deltaTime;

         //transform.position = new Vector3((transform.position.x + enemySpeed), transform.position.y, transform.position.z);
        transform.position = Vector2.MoveTowards(transform.position,_player.transform.position, step);
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.name == "PLAYER")
        {
        }
    }
}

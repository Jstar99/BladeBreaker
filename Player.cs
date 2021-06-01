using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
 

public class Player : MonoBehaviour {
 
	private Animator anim;
	public ActionSelect action;
	public float moveSpeed;
	public int num = -1;
	public GameObject enemy;
	private SpriteRenderer rend;

	public enum Turnstate
	{
		PickingPhase,
		BattlePhase
	}

	public Turnstate curState;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		curState = Turnstate.PickingPhase;  
		rend = GetComponent<SpriteRenderer>();
	
	}


	// Update is called once per frame
	void Update () {
		 
		PlayerMove ();
 	
		switch (curState) {

		case (Turnstate.BattlePhase):
			PlayAnim ();
			break;

		case (Turnstate.PickingPhase):
			 
			break;
		}


		if (transform.position.x > enemy.transform.position.x)
		{
			rend.flipX = true;
		}
		else if(transform.position.x < enemy.transform.position.x)
		{
			rend.flipX = false;
		}
	}
  
	public void PlayAnim()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			num += 1;
			anim.Play (action.ActionSequence.ElementAt (num));

		}
	}
 
	public  void PlayerMove()
	{
		if (Input.GetKeyDown(KeyCode.D)) 
		{
			transform.position = new Vector3 ((transform.position.x + moveSpeed), transform.position.y, transform.position.z);
			 
		}

		else if (Input.GetKeyDown(KeyCode.A)) 
		{
			transform.position = new Vector3 ((transform.position.x - moveSpeed), transform.position.y, transform.position.z); 
		}
	}


	 
}

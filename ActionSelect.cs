using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ActionSelect : MonoBehaviour {
 
	private string Atk1 = "Player-Attack1";
	private string Atk2 = "Player-Attack2";
	private string Atk3 = "Player-Attack3";
	private string Def = "Player-Defend";
	private string Sp  = "Player-Special";
	private string heal = "Player-Heal";

	public Button attack1Button;
	public Button attack2Button;
	public Button attack3Button;
	public Button DefendButton;
	public Button specialButton;
	public Button healButton;
	public GameObject choice;
	public GameObject ready;
	public Player player;

	public List<string> ActionSequence = new List<string> ();
 
 
	// Use this for initialization
	void Start () 
	{
		choice.SetActive (true);
		ready.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(1);
		}
 
		if (ActionSequence.Count == 5)
		{
			choice.SetActive (false);
			ready.SetActive (true);
			player.curState = Player.Turnstate.BattlePhase;
			 
		}	 
	}
 	public void SelectAttack1()
	{
		ActionSequence.Add (Atk1);
		attack1Button.interactable = false;
	}
	public void SelectAttack2()
	{
		ActionSequence.Add (Atk2);
		attack2Button.interactable = false;
	}
	public void SelectAttack3()
	{
		ActionSequence.Add (Atk3);
		attack3Button.interactable = false;
	}
	public void SelectDefend()
	{ 
		ActionSequence.Add (Def);
		DefendButton.interactable = false;
	}
	public void SelectSpecial()
	{
		ActionSequence.Add (Sp);
		specialButton.interactable = false;
	}	
	public void HealthPotion()
	{
		ActionSequence.Add (heal);
		healButton.interactable = false;
	}

}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour {
	public GameObject npcChat;
	public Text npcText;
	private float nextChat;
	private float chatInterval = .09f;
	public GameObject playerChat;
	public Text playerText;
	public int sceneCount;
	public bool endScene = false;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		//Scene Counter
		if (Time.timeScale == 0 && Input.GetKeyUp(KeyCode.Space))
		{
			sceneCount++;
		}

		//End Chatting
		if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Space) && endScene == true)
		{
			Time.timeScale = 1;
			npcChat.SetActive(false);
			endScene = false;
			sceneCount = 0;
		}

		//Chat Dialog
		if (sceneCount == 0 && Input.GetKeyDown(KeyCode.Space))
		{
			npcText.text = "Villager: "+System.Environment.NewLine+"That Margrett is crazy! She’s offering to charm people to get rid of their pain!";


		}
		if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "Where can I find this Margrett? ";

		}
		if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
		{
			playerChat.SetActive(false);
			npcChat.SetActive(true);
			npcText.text = "Villager: "+System.Environment.NewLine+"She’s on the other bank of the river. ";

		}
		if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "She’s definitely a witch, offering charms to people. I need to go and take her in.";
			endScene = true;

		}



	}

	void OnTriggerStay2D (Collider2D npcInteraction)
	{
		if (npcInteraction.gameObject.tag == "Player" && Time.timeScale == 1 && Input.GetKeyDown(KeyCode.Space))
		{
			Time.timeScale = 0;
			npcChat.SetActive(true);

		}
	}
}

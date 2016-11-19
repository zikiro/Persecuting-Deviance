using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Julianna1 : MonoBehaviour {
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
            playerChat.SetActive(false);
            npcChat.SetActive(false);
            endScene = false;
            sceneCount = 0;
        }

        //Chat Dialog
        if (Time.timeScale == 0 && sceneCount == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            npcText.text = "Villager: "+System.Environment.NewLine+"Julianna’s had a lot of male visitors lately.";


		}
		if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "Hmmm. This is the same one accused of adulterous behaviour. This is suspicious. Perhaps she is using some supernatural help.";

		}
		if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "I’ll go to her house to investigate.";
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

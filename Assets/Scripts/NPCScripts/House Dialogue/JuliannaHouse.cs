using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
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
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "I have authority given to me my Summis desiderantes affectibus to enter and search your home. ";

		}
		if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
		{
			playerChat.SetActive(false);
			npcChat.SetActive(true);
			npcText.text = "Julianna: "+System.Environment.NewLine+" I demand you explain to me why you are searching my house!";

		}
		if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "I have a papal bull that gives me permission to search your house to look for evidence of witchcraft.";

		}
		if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
		{

			playerText.text = "Kramer: " +System.Environment.NewLine+ "..."+System.Environment.NewLine+ "I have found a wooden doll, hand carved. I will take this as evidence for the trial.";
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

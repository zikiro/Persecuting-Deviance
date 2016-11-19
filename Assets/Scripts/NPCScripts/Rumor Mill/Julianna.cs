using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Julianna : MonoBehaviour {
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
			npcText.text = "Villager: "+System.Environment.NewLine+"Julianna has been adulterous I hear.";


		}
		if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "Really? This is important. Where can I find this Julianna?";

		}
		if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
		{
			playerChat.SetActive(false);
			npcChat.SetActive(true);
			npcText.text = "Villager: "+System.Environment.NewLine+"She lives fairly close to center of town. You should go there.";

		}
		if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
		{
			npcChat.SetActive(false);
			playerChat.SetActive(true);
			playerText.text = "Kramer: " +System.Environment.NewLine+ "Thank You";
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

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Helen : MonoBehaviour {
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
		npcText.text = "Villager: "+System.Environment.NewLine+"Goodness, I just cannot stand that Helena one more minute!";


	}
	if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
	{
		npcChat.SetActive(false);
		playerChat.SetActive(true);
		playerText.text = "Kramer: " +System.Environment.NewLine+ "Why? What has she done?";

	}
	if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
	{
		playerChat.SetActive(false);
		npcChat.SetActive(true);
		npcText.text = "Villager: "+System.Environment.NewLine+"She’s so spiteful, always threatening everyone if she doesn’t get her way. This time, when I accidentally stepped in her garden, she screeched at me!";

	}
	if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
	{
		npcChat.SetActive(false);
		playerChat.SetActive(true);
		playerText.text = "Kramer: " +System.Environment.NewLine+ "Hmmm....." +System.Environment.NewLine+ "Sounds like quite the temperament. Maybe I should pay some attention to this Helena.";
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

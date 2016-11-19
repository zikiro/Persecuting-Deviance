
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
		npcText.text = "Pope: " + System.Environment.NewLine + "I hearby present you, Henrich Kramer, with the papal bull, Summis desiderantes affectibus, which you requested.\n Kramer. Now you have the power to persecute witchcraft as you wish in Germany, free of restraint from local authorities.";


	}
	if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
	{
		npcChat.SetActive(false);
		playerChat.SetActive(true);
		playerText.text = "Kramer: " + System.Environment.NewLine + "Thank you, your high holiness. I will use this to cleanse this country for God.";
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

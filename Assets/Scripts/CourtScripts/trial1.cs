using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trial1 : MonoBehaviour {

    public GameObject npcChat;
    public Text npcText;
    private float nextChat;
    private float chatInterval = .09f;
    public GameObject playerChat;
    public Text playerText;
    public int sceneCount;
    public bool endScene = false;
    public GameObject witchSelection;
    public bool startScene;
    private CourtMenu CourtMenu;
    public GameObject judge;

    // Use this for initialization
    void Start()
    {
        CourtMenu = judge.GetComponent<CourtMenu>();

    }

    // Update is called once per frame
    void Update()
    {

        

        if (startScene == true)
        {
            Time.timeScale = 0;
            npcChat.SetActive(true);
            

        }

        //Scene Counter
        if (Time.timeScale == 0 && Input.GetKeyUp(KeyCode.Space) && startScene == true)
        {
            sceneCount++;
        }

        //End Chatting
        if (endScene == true)
        {
            Time.timeScale = 1;
            playerChat.SetActive(false);
            npcChat.SetActive(false);
            witchSelection.SetActive(true);
            endScene = false;
            sceneCount = 0;
            startScene = false;
            npcText.text = "Next Trial!";
            CourtMenu.hPressed = true;

        }

        //Chat Dialog
        if (Time.timeScale == 0 && sceneCount == 0 && Input.GetKeyDown(KeyCode.Space) && startScene == true)
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "The accused witch is Helena Scheuberin, accused because of her alleged sexual deviance," + System.Environment.NewLine + "First, she will touch the gospel. Where are you from?";


        }
        if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Helena: " + System.Environment.NewLine + "Innsbruck, sir.";

        }
        if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "What is the status of your parents? Alive or dead?";

        }
        if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Helena: " + System.Environment.NewLine + "Dead, sir.";

        }
        if (sceneCount == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "How did they die?";

        }
        if (sceneCount == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Helena: " + System.Environment.NewLine + "Of natural causes, sir.";

        }
        if (sceneCount == 6 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Where were you brought up?";

        }
        if (sceneCount == 7 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Helena: " + System.Environment.NewLine + "In Innsbruck, sir.";

        }
        if (sceneCount == 8 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "I will call Henrich Kramer to testify against the accused witch.";

        }
        if (sceneCount == 9 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "Sir. I know the witch because I have been given the papal bull to persecute witchcraft in Germany.";

        }
        if (sceneCount == 10 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "I have not known the accused for very long, but I have very clear evidence she is a witch.";

        }
        if (sceneCount == 11 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "She has exhibited sexually deviant behaviour, and under my interrogation, has confessed to magical connections with the Devil.";

        }
        if (sceneCount == 12 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "Therefore, your honor, she deserves to be convicted guilty and executed.";

        }
        if (sceneCount == 13 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "I see. I’m very familiar with your questioning, Kramer. Furthermore there is no evidence to link Helena Scheuberin’s possibly sexually deviant behaviour.";

        }
        if (sceneCount == 14 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Her parents, this town, and her upbringing has no connection to witchcraft, no consort with the Devil. I declare her innocent.";
            endScene = true;
            
        }



        
    }


}


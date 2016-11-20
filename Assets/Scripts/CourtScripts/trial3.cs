using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trial3 : MonoBehaviour {

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
            CourtMenu.mPressed = true;
        }

        //Chat Dialog
        if (Time.timeScale == 0 && sceneCount == 0 && Input.GetKeyDown(KeyCode.Space) && startScene == true)
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "The accused witch is Margrett Sommer. She is accused of cursing a fellow citizen with wracking pains with an evil spell.";


        }
        if (sceneCount == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Touch the Gospel, and let the Trial Begin. Were you born and raised in Innsbruck?";

        }
        if (sceneCount == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Margrett: " + System.Environment.NewLine + "Yes, milord. ";

        }
        if (sceneCount == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Are your parents alive or dead?";

        }
        if (sceneCount == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Margrett: " + System.Environment.NewLine + "Gone and Buried, milord. ";

        }
        if (sceneCount == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Were they burned for heresy or witchcraft?";

        }
        if (sceneCount == 6 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Margrett:: " + System.Environment.NewLine + "My mother was, sir.";

        }
        if (sceneCount == 7 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Kramer. I call you to the stand to testify on the accused. I hope for your sake that this one is not a complete waste of time.";

        }
        if (sceneCount == 8 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "No, your honor. This woman has made charms to hex others, causing them intense pains that consume the cursed one’s entire body.";

        }
        if (sceneCount == 9 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "She furthermore then profited by selling charms to cure people that she herself hexed.";

        }
        if (sceneCount == 10 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "And I suppose you have a witness to come to the stand that bought one of these charms?";

        }
        if (sceneCount == 11 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "No, your honor, I do not.";

        }
        if (sceneCount == 12 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "I have had enough. As the mayor of this town, I have had enough. You will leave.";

        }
        if (sceneCount == 13 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "You will stop this fool’s errand. All those you have accused have been a complete and utter waste of everyone’s time.";

        }
        if (sceneCount == 14 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Now go. ";
            endScene = true;
        }




    }


}

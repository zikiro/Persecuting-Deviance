using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trial2 : MonoBehaviour {

    public GameObject npcChat;
    public Text npcText;
    private float nextChat;
    private float chatInterval = .09f;
    public GameObject playerChat;
    public Text playerText;
    public int sceneCount2;
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
            sceneCount2++;
        }

        //End Chatting
        if (endScene == true)
        {
            Time.timeScale = 1;
            playerChat.SetActive(false);
            npcChat.SetActive(false);
            witchSelection.SetActive(true);
            endScene = false;
            sceneCount2 = 0;
            startScene = false;
            npcText.text = "Next Trial!";
            CourtMenu.jPressed = true;
        }

        //Chat Dialog
        if (Time.timeScale == 0 && sceneCount2 == 0 && Input.GetKeyDown(KeyCode.Space) && startScene == true)
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "The accused witch, Julianna Keller, will come to the stand. You are charged with using a doll to charm men to engage in adulterous relations with her.";


        }
        if (sceneCount2 == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "She will now be sworn in. Please, touch the Gospel. Where are you from?";

        }
        if (sceneCount2 == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Juliana: " + System.Environment.NewLine + "I am from Innsbruck, your honor";

        }
        if (sceneCount2 == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Are your parents alive or dead?";

        }
        if (sceneCount2 == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Juliana: " + System.Environment.NewLine + "My parents are dead, both of natural causes, your honor.";

        }
        if (sceneCount2 == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Were you born and raised in Innsbruck?";

        }
        if (sceneCount2 == 6 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Juliana: " + System.Environment.NewLine + "Yes, your honor.";

        }
        if (sceneCount2 == 7 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "I will now call Henrich Kramer to the stand to testify as a witness. Why do you accuse this woman?";
            
        }
        if (sceneCount2 == 8 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            
            
            
            npcText.text = "Kramer: " + System.Environment.NewLine + "This woman is witch. She stands here today because she consorted with the Devil himself for power to enchant a doll.";

        }
        if (sceneCount2 == 9 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "She used this enchanted doll to draw men into her ensnaring trap, forcing them into adulterous relationships with her.";

        }
        if (sceneCount2 == 10 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "With her command of the supernatural, she may already have power over us. We must execute quickly!";

        }
        if (sceneCount2 == 11 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "Her open adulterous and scandalous behavior clearly marks her a witch!";

        }
        if (sceneCount2 == 12 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "And can you prove this? Can you bring one of these men to the stand to testify?";

        }
        if (sceneCount2 == 13 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Kramer: " + System.Environment.NewLine + "No, your honor. I cannot. But the doll, I have the doll!";

        }
        if (sceneCount2 == 14 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcText.text = "Judge: " + System.Environment.NewLine + "Enough of your games, Kramer. This woman is innocent. Stop wasting the court’s time. The accused is declared innocent. She is free to go.";
            endScene = true;

        }




    }


}
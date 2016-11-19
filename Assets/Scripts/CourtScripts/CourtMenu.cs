using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CourtMenu : MonoBehaviour {
    public GameObject accusedMenu;
    public bool endScene = false;
    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npc5;
    public GameObject npc6;
    public GameObject npc7;
    public GameObject npc8;
    public GameObject npc9;
    public GameObject npc10;
    private Transform npc1Target;
    private Transform npc2Target;
    private Transform npc3Target;
    private Transform npc4Target;
    private Transform npc5Target;
    private Transform npc6Target;
    private Transform npc7Target;
    private Transform npc8Target;
    private Transform npc9Target;
    private Transform npc10Target;
    public bool mPressed = false;
    public bool jPressed = false;
    public bool hPressed = false;
    public bool lPressed = false;
    public Text endGame;
    public float loseTime = 1000000000000;
    public float endGameTime;
    public float onStandTime = 100000000000000;
    public int sceneCount;
    public GameObject npcChat;
    public Text npcText;
    private float nextChat;
    private float chatInterval = .09f;
    public GameObject playerChat;
    public Text playerText;
    public bool mEnd = false;

    // Use this for initialization
    void Start () {
        npc1Target = npc1.transform;
        npc2Target = npc2.transform;
        npc3Target = npc3.transform;
        npc4Target = npc4.transform;
        npc5Target = npc5.transform;
        npc6Target = npc6.transform;
        npc7Target = npc7.transform;
        npc8Target = npc8.transform;
        npc9Target = npc9.transform;
        npc10Target = npc10.transform;

    }
	
	// Update is called once per frame
	void Update () {

        if (Time.timeScale == 0 && Input.GetKeyUp(KeyCode.Space))
        {
            endScene = true;
        }
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Space) && endScene == true)
        {
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
            endScene = false;
        }

        if (mPressed == true && jPressed == true && hPressed == true)
        {
            accusedMenu.SetActive(false);
            mPressed = false;
            jPressed = false;
            hPressed = false;
            endGame.text = "YOU WIN!";
            loseTime = Time.time + 5;
        }
        else if (lPressed == true)
        {
            accusedMenu.SetActive(false);
            lPressed = false;
            endGame.text = "YOU CONVICTED AN INNOCENT PERSON!" + System.Environment.NewLine + "YOU LOSE!";
            loseTime = Time.time + 5;
        }


        if (Time.time > loseTime)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    void OnTriggerStay2D(Collider2D accusedCall)
    {
        if (accusedCall.gameObject.tag == "Player" && Time.timeScale == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            accusedMenu.SetActive(true);

        }
    }
    public void AccusedChoice(string WitchChoice)
    {
        if (WitchChoice == "Choice_1")
        {
            mPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = true;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;

            

        }
        if (WitchChoice == "Choice_2")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = true;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_3")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = true;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_4")
        {
            jPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = true;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            
        }
        if (WitchChoice == "Choice_5")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = true;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_6")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = true;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_7")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = true;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_8")
        {
            hPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = true;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            
        }
        if (WitchChoice == "Choice_9")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = true;
            npc10Target.GetComponent<CallToTheStand>().onStand = false;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }
        if (WitchChoice == "Choice_10")
        {
            lPressed = true;
            npc1Target.GetComponent<CallToTheStand>().onStand = false;
            npc2Target.GetComponent<CallToTheStand>().onStand = false;
            npc3Target.GetComponent<CallToTheStand>().onStand = false;
            npc4Target.GetComponent<CallToTheStand>().onStand = false;
            npc5Target.GetComponent<CallToTheStand>().onStand = false;
            npc6Target.GetComponent<CallToTheStand>().onStand = false;
            npc7Target.GetComponent<CallToTheStand>().onStand = false;
            npc8Target.GetComponent<CallToTheStand>().onStand = false;
            npc9Target.GetComponent<CallToTheStand>().onStand = false;
            npc10Target.GetComponent<CallToTheStand>().onStand = true;
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
        }

    }

}

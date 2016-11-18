using UnityEngine;
using System.Collections;

public class CourtMenu : MonoBehaviour {
    public GameObject accusedMenu;
    public bool endScene;

    // Use this for initialization
    void Start () {
	
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
        if (Time.timeScale == 0 && Input.GetMouseButtonUp(0) && endScene == true)
        {
            Time.timeScale = 1;
            accusedMenu.SetActive(false);
            endScene = false;
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
            endScene = true;
        }
        if (WitchChoice == "Choice_2")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_3")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_4")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_5")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_6")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_7")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_8")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_9")
        {
            endScene = true;
        }
        if (WitchChoice == "Choice_10")
        {
            endScene = true;
        }

    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AccusedChoice(string WitchChoice)
    {
        if (WitchChoice == "Main")
        {

            SceneManager.LoadScene("MainMenu");


        }
        if (WitchChoice == "Quit")
        {
            Application.Quit();
        }



    }


}

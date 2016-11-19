using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainScreenMenu : MonoBehaviour {

    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    public void AccusedChoice(string WitchChoice)
    {
        if (WitchChoice == "Start")
        {

            SceneManager.LoadScene("Intro");


        }
        if (WitchChoice == "Quit")
        {
            Application.Quit();
        }
       
       

    }

}


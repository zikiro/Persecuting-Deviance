using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HouseEnter : MonoBehaviour {
    public string houseScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter2D(Collision2D houseCollision)
    {
        if (houseCollision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("" + houseScene);
        }
    }

  }

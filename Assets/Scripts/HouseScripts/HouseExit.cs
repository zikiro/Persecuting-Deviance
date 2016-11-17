using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HouseExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D doorCollision)
    {
        if (doorCollision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Village");
        }
    }


}

using UnityEngine;
using System.Collections;

public class StartScenes : MonoBehaviour {
    private trial1 trial1;
    private trial2 trial2;
    private trial3 trial3;

    // Use this for initialization
    void Start () {
	
        trial1 = GetComponent<trial1>();
        trial2 = GetComponent<trial2>();
        trial3 = GetComponent<trial3>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D npcInteraction)
    {
        if (npcInteraction.gameObject.tag == "Helena")
        {
            Time.timeScale = 0;
            trial1.startScene = true;

        }
        if (npcInteraction.gameObject.tag == "Juliana")
        {
            Time.timeScale = 0;
            trial2.startScene = true;

        }
        if (npcInteraction.gameObject.tag == "Margrett")
        {
            Time.timeScale = 0;
            trial3.startScene = true;

        }
    }
}

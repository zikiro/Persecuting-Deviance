using UnityEngine;
using System.Collections;

public class NPCInteraction : MonoBehaviour {

    public GameObject npcChat;
    private float nextChat;
    private float chatInterval = .09f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.timeScale == 0 && Input.GetKeyUp(KeyCode.Space))
        {
            nextChat -= 1;
        }

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Space) && Time.time > nextChat)
        {
            Time.timeScale = 1;
            npcChat.SetActive(false);
        }

    }

    void OnTriggerStay2D (Collider2D npcInteraction)
    {
        if (npcInteraction.gameObject.tag == "Player" && Time.timeScale == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            npcChat.SetActive(true);
            nextChat = Time.time + chatInterval;
        }
    }
}

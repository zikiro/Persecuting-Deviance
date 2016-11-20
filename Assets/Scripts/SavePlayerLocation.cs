using UnityEngine;
using System.Collections;

public class SavePlayerLocation : MonoBehaviour {
    public bool play = true;
    public GameObject player;
    private int playerAmt;

    // Use this for initialization
    void Start () {
        Load();
	
	}
	
	// Update is called once per frame
	void Update () {


        
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y -1);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);

    }

    void Load()
    {

        Destroy(player);

        if (PlayerPrefs.GetFloat("PlayerY") != null)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));

        
        }
    }

    void Save()
    {
        




        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }

}

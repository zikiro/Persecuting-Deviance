using UnityEngine;
using System.Collections;

public class TownWalk : MonoBehaviour {

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
    public GameObject spawnZone;
    private float minPosx = 0f;
    private float maxPosx = 0f;
    private float minPosy = 0f;
    private float maxPosy = 0f;
    public Vector3 npcPos = new Vector3();
    private int randomCharacter;

    // Use this for initialization
    void Start () {

        //This sets the spawn min and max for x and y using the gameobject provided
        minPosx = spawnZone.transform.position.x - spawnZone.transform.localScale.x / 2;
        maxPosx = spawnZone.transform.position.x + spawnZone.transform.localScale.x / 2;
        minPosy = spawnZone.transform.position.y - spawnZone.transform.localScale.y / 2;
        maxPosy = spawnZone.transform.position.y + spawnZone.transform.localScale.y / 2;

        randomCharacter = Random.Range(1, 10);
        //Setting the enemyPos to random x,y
        npcPos.x = Random.Range(minPosx, maxPosx);
        npcPos.y = Random.Range(minPosy, maxPosy);

        if (randomCharacter == 1)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc1, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 2)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc2, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 3)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc3, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 4)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc4, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 5)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc5, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 6)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc6, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 7)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc7, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 8)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc8, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 9)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc9, npcPos, Quaternion.identity);
        }
        else if (randomCharacter == 10)
        {
            //Spawning a enemy at the new random enemy position
            Instantiate(npc10, npcPos, Quaternion.identity);
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class VariedSpawnAreas : MonoBehaviour {

    public GameObject npc;
    public GameObject spawnZone;
    public GameObject spawnZone2;
    public GameObject spawnZone3;
    public GameObject spawnZone4;
    public GameObject spawnZone5;
    public GameObject spawnZone6;
    private float minPosx = 0f;
    private float maxPosx = 0f;
    private float minPosy = 0f;
    private float maxPosy = 0f;
    public Vector3 npcPos = new Vector3();
    private int randomSpawn;
    public int spawnAreas;


    void Start()
    {

        randomSpawn = Random.Range(0, (spawnAreas + 1));

        if (randomSpawn == 1)
        {

            //This sets the spawn min and max for x and y using the gameobject provided
            minPosx = spawnZone.transform.position.x - spawnZone.transform.localScale.x / 2;
            maxPosx = spawnZone.transform.position.x + spawnZone.transform.localScale.x / 2;
            minPosy = spawnZone.transform.position.y - spawnZone.transform.localScale.y / 2;
            maxPosy = spawnZone.transform.position.y + spawnZone.transform.localScale.y / 2;
        }
        else if (randomSpawn == 2)
        {
            //This sets the spawn min and max for x and y using the gameobject provided
            minPosx = spawnZone2.transform.position.x - spawnZone2.transform.localScale.x / 2;
            maxPosx = spawnZone2.transform.position.x + spawnZone2.transform.localScale.x / 2;
            minPosy = spawnZone2.transform.position.y - spawnZone2.transform.localScale.y / 2;
            maxPosy = spawnZone2.transform.position.y + spawnZone2.transform.localScale.y / 2;
        }
        else if (randomSpawn == 3)
        {
            //This sets the spawn min and max for x and y using the gameobject provided
            minPosx = spawnZone3.transform.position.x - spawnZone3.transform.localScale.x / 2;
            maxPosx = spawnZone3.transform.position.x + spawnZone3.transform.localScale.x / 2;
            minPosy = spawnZone3.transform.position.y - spawnZone3.transform.localScale.y / 2;
            maxPosy = spawnZone3.transform.position.y + spawnZone3.transform.localScale.y / 2;
        }
        else if (randomSpawn == 4)
        {
            //This sets the spawn min and max for x and y using the gameobject provided
            minPosx = spawnZone4.transform.position.x - spawnZone4.transform.localScale.x / 2;
            maxPosx = spawnZone4.transform.position.x + spawnZone4.transform.localScale.x / 2;
            minPosy = spawnZone4.transform.position.y - spawnZone4.transform.localScale.y / 2;
            maxPosy = spawnZone4.transform.position.y + spawnZone4.transform.localScale.y / 2;
        }
        else if (randomSpawn == 5)
        {
            //This sets the spawn min and max for x and y using the gameobject provided
            minPosx = spawnZone5.transform.position.x - spawnZone5.transform.localScale.x / 2;
            maxPosx = spawnZone5.transform.position.x + spawnZone5.transform.localScale.x / 2;
            minPosy = spawnZone5.transform.position.y - spawnZone5.transform.localScale.y / 2;
            maxPosy = spawnZone5.transform.position.y + spawnZone5.transform.localScale.y / 2;
        }
        else if (randomSpawn == 6)
        {
            //This sets the spawn min and max for x and y using the gameobject provided
        minPosx = spawnZone6.transform.position.x - spawnZone6.transform.localScale.x / 2;
        maxPosx = spawnZone6.transform.position.x + spawnZone6.transform.localScale.x / 2;
        minPosy = spawnZone6.transform.position.y - spawnZone6.transform.localScale.y / 2;
        maxPosy = spawnZone6.transform.position.y + spawnZone6.transform.localScale.y / 2;
}



        //Setting the enemyPos to random x,y
        npcPos.x = Random.Range(minPosx, maxPosx);
        npcPos.y = Random.Range(minPosy, maxPosy);

        Instantiate(npc, npcPos, Quaternion.identity);






    }

}


using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    public int numEnemies;
    public int minEnemies = 1;
    public int maxEnemies = 15;
    public int enemyCount = 0;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject spawnZone;
    private float minPosx = 0f;
    private float maxPosx = 0f;
    private float minPosy = 0f;
    private float maxPosy = 0f;
    public Vector3 enemyPos = new Vector3();
    public float spawnDelay = 30f;
    private float nextSpawn = 0.0f;
    private int randomCharacter;
    public int characterAmount;


    void Start () {

        //This sets the spawn min and max for x and y using the gameobject provided
        minPosx = spawnZone.transform.position.x - spawnZone.transform.localScale.x / 2;
        maxPosx = spawnZone.transform.position.x + spawnZone.transform.localScale.x / 2;
        minPosy = spawnZone.transform.position.y - spawnZone.transform.localScale.y / 2;
        maxPosy = spawnZone.transform.position.y + spawnZone.transform.localScale.y / 2;

        //Giving it a random number of enemies
        numEnemies = Random.Range(minEnemies, maxEnemies);

        for(int i = 0; i < numEnemies; i++)
        {

            randomCharacter = Random.Range(0, (characterAmount + 1));
            //Setting the enemyPos to random x,y
            enemyPos.x = Random.Range(minPosx, maxPosx);
            enemyPos.y = Random.Range(minPosy, maxPosy);

            if (randomCharacter == 1)
            {
                //Spawning a enemy at the new random enemy position
                Instantiate(enemy, enemyPos, Quaternion.identity);
            }
            else if (randomCharacter == 2)
            {
                //Spawning a enemy at the new random enemy position
                Instantiate(enemy2, enemyPos, Quaternion.identity);
            }
            else if (randomCharacter == 3)
            {
                //Spawning a enemy at the new random enemy position
                Instantiate(enemy3, enemyPos, Quaternion.identity);
            }
            else if (randomCharacter == 4)
            {
                //Spawning a enemy at the new random enemy position
                Instantiate(enemy4, enemyPos, Quaternion.identity);
            }
            else if (randomCharacter == 5)
            {
                //Spawning a enemy at the new random enemy position
                Instantiate(enemy5, enemyPos, Quaternion.identity);
            }


            enemyCount = enemyCount + 1;
        }
	}

    void FixedUpdate()
    {
        if (enemyCount < numEnemies)
        {
            
            if (Time.time > nextSpawn)
            {
                randomCharacter = Random.Range(1, 5);
                //Setting the enemyPos to random x,y
                enemyPos.x = Random.Range(minPosx, maxPosx);
                enemyPos.y = Random.Range(minPosy, maxPosy);

                if (randomCharacter == 1)
                {
                    //Spawning a enemy at the new random enemy position
                    Instantiate(enemy, enemyPos, Quaternion.identity);
                }
                else if (randomCharacter == 2)
                {
                    //Spawning a enemy at the new random enemy position
                    Instantiate(enemy2, enemyPos, Quaternion.identity);
                }
                else if (randomCharacter == 3)
                {
                    //Spawning a enemy at the new random enemy position
                    Instantiate(enemy3, enemyPos, Quaternion.identity);
                }
                else if (randomCharacter == 4)
                {
                    //Spawning a enemy at the new random enemy position
                    Instantiate(enemy4, enemyPos, Quaternion.identity);
                }
                else if (randomCharacter == 5)
                {
                    //Spawning a enemy at the new random enemy position
                    Instantiate(enemy5, enemyPos, Quaternion.identity);
                }

                enemyCount = enemyCount + 1;
                nextSpawn = Time.time + spawnDelay;
            }
        }
    }
}

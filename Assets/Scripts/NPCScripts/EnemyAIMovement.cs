using UnityEngine;
using System.Collections;

public class EnemyAIMovement : MonoBehaviour {


    public int moveSpeed;
    public float playerRange;
    public LayerMask playerLayer;
    public bool playerInRange;
    private float xStart;
    private float yStart;
    public float roamArea;
    private float xMax;
    private float xMin;
    private float yMax;
    private float yMin;
    private float randomX;
    private float randomY;
    private Vector3 destination;

    // Use this for initialization
    void Start()
    {
        //Initiating the enemy's defined roaming area.
        xStart = transform.position.x;
        yStart = transform.position.y;
        xMax = xStart + roamArea;
        xMin = xStart - roamArea;
        yMax = yStart + roamArea;
        yMin = yStart - roamArea;
        randomX = Random.Range(xMin, xMax);
        randomY = Random.Range(yMin, yMax);
        



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Checking if player is in range of enemy.
        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);

        //Visual display to see what target it's searching for.
        //Visual display to see the next location enemy is heading towards.
        Debug.DrawLine(destination, transform.position, Color.green);


        //If the enemy is in range of the player it will follow after player to any location.
        //If it's not in range of player will find a random location in it's defined area.

            //Work around for all enemies going to position 0,0,0 for first destination.
            if (destination != new Vector3(0, 0, 0))
            {
                //Checking if the enemy has reached the random position.
                if (transform.position != destination)
                {
                    transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
                }
                //Generating a new random position in it's defined area.
                else
                {
                    randomX = Random.Range(xMin, xMax);
                    randomY = Random.Range(yMin, yMax);
                    destination = new Vector3(randomX, randomY, 0);

                }
            }
            //Initiating the first random position in it's defined area.
            else
            {
                destination = new Vector3(randomX, randomY, 0);
            }
 


        

    }

    void OnDrawGizmosSelected()
    {
        //Visual display to show the detection range for the enemy to search for the player.
        Gizmos.DrawSphere(transform.position, playerRange);
    }



}

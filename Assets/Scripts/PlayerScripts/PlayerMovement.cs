using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;

    private float runningSpeed;
    private bool playerMoving;
    private Vector2 lastMove;
	private Animator animator; 

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        playerMoving = false;
        runningSpeed = 1;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            runningSpeed = 1.5f;
        }

        // Handles left and right movement
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {

                     
			if(Input.GetAxisRaw("Horizontal") > 0.1f){
				transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime * runningSpeed, 0f, 0f));
				animator.SetTrigger("PlayerWalkEast");
				playerMoving = true;
			}
			else if(Input.GetAxisRaw("Horizontal") < -0.1f){
				transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime * runningSpeed, 0f, 0f));
				animator.SetTrigger("PlayerWalkWest");
				playerMoving = true;
			}

        }

        // Handles up and down movement
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {

            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime * runningSpeed, 0f));
			if(Input.GetAxisRaw("Vertical") > 0.1f){
				animator.SetTrigger("PlayerWalkNorth");
				playerMoving = true;
				lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
			}
			else if(Input.GetAxisRaw("Vertical") < -0.1f){
				animator.SetTrigger("PlayerWalkSouth");
				playerMoving = true;
				lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
			}

        }

    }
}

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;

    private float runningSpeed;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;
    public GameObject pause;


    // Use this for initialization
    void Start()
    {
        
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
            Time.timeScale = 0;
            pause.SetActive(true);
            }
            else
            {
                
                    Time.timeScale = 1;
                    pause.SetActive(false);

              
            }

        }

    }

        // Update is called once per frame
        void FixedUpdate()
    {

        
        runningSpeed = 1;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            runningSpeed = 1.5f;
        }

        // Handles left and right movement
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime * runningSpeed, 0f, 0f));
            
            
        }

        // Handles up and down movement
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime * runningSpeed, 0f));
           
            
        }

        // Sends data to the animator --{
        // Determines which way the player is moving
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        // Determines if the player is moving
        // }--
    }
}

using UnityEngine;
using System.Collections;

public class CallToTheStand : MonoBehaviour {

    public bool onStand = false;
    public GameObject standPosition;
    public GameObject seatPosition;
    private Transform standTarget;
    private Transform seatTarget;
    public float moveSpeed;

    // Use this for initialization
    void Start () {

        

        standTarget = standPosition.transform;
        seatTarget = seatPosition.transform;

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (onStand == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, standTarget.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, seatTarget.position, moveSpeed * Time.deltaTime);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D myRigibody;
    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCount;

    public float timeToMove;
    private float timeToMoveCount;

    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
        myRigibody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCount = timeBetweenMove;
        timeToMoveCount = timeToMove;
	}
	
	// Update is called once per frame
	void Update () {

        if (moving)
        {
            timeToMoveCount -= Time.deltaTime;
            myRigibody.velocity = moveDirection;

            if(timeToMoveCount < 0f)
            {
                moving = false;
                timeBetweenMoveCount = timeBetweenMove;
            }
        }
        else
        {
            timeBetweenMoveCount -= Time.deltaTime;
            myRigibody.velocity = Vector2.zero;


            if(timeBetweenMoveCount < 0f)
            {
                moving = true;
                timeToMoveCount = timeToMove;

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }

	}
}

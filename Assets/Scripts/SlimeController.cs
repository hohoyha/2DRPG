using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D myRigibody;
    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCount;

    public float timeToMove;
    private float timeToMoveCount;

    private Vector3 moveDirection;

    public float waitToReload;
    private bool reloadig = false;
    private GameObject thePlayer;

	// Use this for initialization
	void Start () {
        myRigibody = GetComponent<Rigidbody2D>();

        //timeBetweenMoveCount = timeBetweenMove;
        //timeToMoveCount = timeToMove;

        timeBetweenMoveCount = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCount = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);
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
                //timeBetweenMoveCount = timeBetweenMove;
                timeBetweenMoveCount = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
            }
        }
        else
        {
            timeBetweenMoveCount -= Time.deltaTime;
            myRigibody.velocity = Vector2.zero;


            if(timeBetweenMoveCount < 0f)
            {
                moving = true;
                //timeToMoveCount = timeToMove;
                timeToMoveCount = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }

        if (reloadig)
        {
            waitToReload -= Time.deltaTime;
            if(waitToReload < 0)
            {
                SceneManager.LoadScene("main");
                thePlayer.SetActive(true);
               
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if(collision.gameObject.name == "Player")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            reloadig = true;
            thePlayer = collision.gameObject;
        }
        */
    }
}

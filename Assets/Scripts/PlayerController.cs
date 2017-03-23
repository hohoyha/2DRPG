using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private Animator anim;

    private bool playerMoving;
    private Vector2 lastMove;
	// Use this for initialization
	void Start () {
   
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        playerMoving = false;

        if (h > 0.5f || h < -0.5f)
        {
            transform.Translate(new Vector3(h * moveSpeed * Time.deltaTime, 0, 0));
            playerMoving = true;
            lastMove = new Vector2(h, 0);
        }

        if (v > 0.5f || v < -0.5f)
        {
            transform.Translate(new Vector3( 0, v * moveSpeed * Time.deltaTime, 0));
            playerMoving = true;
            lastMove = new Vector2(0, v);
        }

        anim.SetFloat("MoveX", h);
        anim.SetFloat("MoveY", v);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

        anim.SetBool("Moving", playerMoving);

    }
}

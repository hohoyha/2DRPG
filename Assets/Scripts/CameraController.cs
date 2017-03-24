using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = followTarget.transform.position;
        targetPos = new Vector3(pos.x, pos.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPos, 
            moveSpeed * Time.deltaTime);
	}
}

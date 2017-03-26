using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damage = 10;
    public GameObject damgeBurst;
    public Transform HitPoint;
    public GameObject damageNumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damage);
            Instantiate(damgeBurst, HitPoint.transform.position, HitPoint.transform.rotation);
            GameObject clone = (GameObject)Instantiate(damageNumber, HitPoint.transform.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damgeNumber = damage;
        }
    }
}

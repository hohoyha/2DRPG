using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManger : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHeath;
	// Use this for initialization
	void Start () {
        playerCurrentHeath = playerMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerCurrentHeath <= 0)
        {
            gameObject.SetActive(false);


        }
	}

    public void HurtPlayer(int damageToGive )
    {
        playerCurrentHeath -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHeath = playerMaxHealth;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;
    public PlayerHealthManger playerHealth;

    private static bool UIExists;
	// Use this for initialization
	void Start () {

        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHeath;
        HPText.text = "HP: " + playerHealth.playerCurrentHeath + "/" 
            + playerHealth.playerMaxHealth;
    }
}

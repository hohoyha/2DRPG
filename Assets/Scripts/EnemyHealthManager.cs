using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHeath;
    // Use this for initialization
    void Start()
    {
        CurrentHeath = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHeath <= 0)
        {
            Destroy(gameObject);


        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHeath -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHeath = MaxHealth;
    }
}

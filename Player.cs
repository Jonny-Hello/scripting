using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 10f;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int Coins = 0;
    // Update is called once per frame
    public void TakeDamage(float damage)
    {
      health -= damage;
        print("Player health: " + health);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
    public void CollectCoins()
    {
        Coins++;
        print("Coins collected: " + Coins);
    }
}

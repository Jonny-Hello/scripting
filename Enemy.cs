using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float damage = 2f;  
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(damage);
    }
}

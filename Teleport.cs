using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    // Start is called before the first frame update
    void Onenter (Collider other)
    {
       other.transform.position = teleportPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

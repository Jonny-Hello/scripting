using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedfactor = 2.5f;
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other)
    {
      other.GetComponent<FirstPersonMovement>().runSpeed *= speedfactor; 
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedfactor;
    }
}

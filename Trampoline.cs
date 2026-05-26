using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength += 10;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength -= 10;
    }
}

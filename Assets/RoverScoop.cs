using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverScoop : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("rover"))
        {
            other.gameObject.GetComponent<RoverAnimationController>().Stop();
            other.gameObject.GetComponent<RoverAnimationController>().StartBucket();
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("rover"))
        {
            other.gameObject.GetComponent<RoverAnimationController>().Stop();
            other.gameObject.GetComponent<RoverAnimationController>().StartVacuum();
        }
    }

} 

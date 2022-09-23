using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverAnimationController : MonoBehaviour
{
    public void StartVacuum()
    {
        gameObject.GetComponent<Animation>().Play("rover movement vacuum");
    }

    public void StartBucket()
    {
        gameObject.GetComponent<Animation>().Play("rover movement bucket");
    }


    public void Stop()
    {
        gameObject.GetComponent<Animation>().Stop();
    }
}

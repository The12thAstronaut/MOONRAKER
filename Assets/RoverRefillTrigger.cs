using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverRefillTrigger : MonoBehaviour
{
    public GameObject QueenBee;

    public void StartRefill()
    {
        QueenBee.GetComponent<Animation>().Play("SceneAnimation");
    }
}

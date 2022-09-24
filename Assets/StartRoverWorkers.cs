using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRoverWorkers : MonoBehaviour
{
    public GameObject DomeSite;
    public void StartAnim()
    {
        DomeSite.GetComponent<Animation>().Play("rover workers");
    }
}

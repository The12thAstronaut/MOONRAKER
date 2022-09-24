using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleArrived : MonoBehaviour
{
    public GameObject module;
    public void SetModuleActive()
    {
        module.SetActive(true);
    }
}

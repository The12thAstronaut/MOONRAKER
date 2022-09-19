using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayEndpoint : MonoBehaviour
{
    Vector3 initPos;

    [SerializeField]
    [Range (0f, 1f)]
    float speed;

    [SerializeField]
    [Range(0f, 1f)]
    float amplitude;

    [SerializeField]
    bool x;
    [SerializeField]
    bool y;
    [SerializeField]
    bool z;

    float xPos;
    float yPos;
    float zPos;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!x)
        {
            xPos = transform.position.x;
        }

        else
        {
            xPos = initPos.x + amplitude * (Mathf.Sin(speed * Time.time));
        }

        if (!y)
        {
            yPos = transform.position.y;
        }
        else
        {
            yPos = initPos.y + amplitude * (Mathf.Sin(speed * Time.time));
        }

        if (!z)
        {
            zPos = transform.position.z;
        }
        else
        {
            zPos = initPos.z + amplitude * (Mathf.Sin(speed * Time.time));
        }

        gameObject.transform.position = new Vector3(xPos, yPos, zPos);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverTerrainModifier : MonoBehaviour
{
    public Terrain terrain;
    TerrainTool terrainTool;
    // Start is called before the first frame update
    void Awake()
    {
        terrainTool = FindObjectOfType<TerrainTool>();
        terrainTool._targetTerrain = terrain;
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("rover"))
        {
            terrainTool.RaiseTerrain(collision.transform.position, terrainTool.strength, terrainTool.brushHeight, terrainTool.brushHeight);
            collision.gameObject.GetComponent<RoverAnimationController>().StartBucket();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScenerySpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> tilePrefabs = new List<GameObject>();
    [SerializeField] private int gridSizeX;
    [SerializeField] private int gridSizeZ;
    private Vector3 spawnPosition;
    private float offset = 0.5f;

    private void Awake()
    {
        spawnPosition = new Vector3(-(gridSizeX / 2), 0f, -(gridSizeZ / 2));
    }

    void Start()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                int randomIndex = Random.Range(0,tilePrefabs.Count);
                Vector3 position = new Vector3(spawnPosition.x + (x + offset), 0f, spawnPosition.z + (z + offset));
                Instantiate(tilePrefabs[randomIndex], position, Quaternion.identity);
            }
        }
    }

}

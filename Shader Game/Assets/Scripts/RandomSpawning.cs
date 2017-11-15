﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawning : MonoBehaviour {

    public Vector3 center;
    public Vector3 size;

    public GameObject[] foodPrefabs;

    private void Start()
    {
        InvokeRepeating("SpawnFood", 2f, 2f);
    }

    void SpawnFood()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        int foodIndex = Random.Range(0, foodPrefabs.Length);
        Instantiate(foodPrefabs[foodIndex], pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}

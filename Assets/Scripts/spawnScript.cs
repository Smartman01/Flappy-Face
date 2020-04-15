using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(prefab, new Vector3(spawnPoint.position.x, spawnPoint.position.y), Quaternion.identity);
    }
}

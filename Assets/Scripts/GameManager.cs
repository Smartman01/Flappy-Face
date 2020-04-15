using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text scoreTxt;

    public spawnScript[] spawnScripts;

    private void Awake()
    {
        spawnScripts = FindObjectsOfType(typeof(spawnScript)) as spawnScript[];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void SpawnLevel()
    {
        foreach (spawnScript s in spawnScripts)
            s.Spawn();
    }
}

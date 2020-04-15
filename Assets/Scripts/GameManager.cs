using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text scoreTxt;

    public spawnScript spawnSc;

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void SpawnLevel()
    {
        spawnSc.Spawn();
    }

    public void StartGame()
    {
        // Close Start Menu
    }

    public void GameOver()
    {
        // Save score

        // Open Death Menu
    }
}

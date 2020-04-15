using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float randY;

    public Transform pos;

    [SerializeField]
    GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        randY = Random.Range(minY, maxY);

        pos.position = new Vector2(pos.position.x, randY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        gm.score++;

        // Play Sound

        gm.SpawnLevel();
    }
}

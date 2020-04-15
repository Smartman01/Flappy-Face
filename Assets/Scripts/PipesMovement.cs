﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float randY;
    public float boundry;
    public float speed;

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

        pos.position.Set(pos.position.x, randY, pos.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos.position = new Vector2(pos.position.x - Time.deltaTime * speed, randY);

        if (pos.position.x <= boundry)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        gm.score++;

        gm.SpawnLevel();
    }
}

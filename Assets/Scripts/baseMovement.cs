using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMovement : MonoBehaviour
{
    public float boundry;
    public float speed;

    public Transform pos;

    [SerializeField]
    GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos.position = new Vector2(pos.position.x - Time.deltaTime * speed, pos.position.y);

        if (pos.position.x <= boundry)
            Destroy(this.gameObject);
    }
}

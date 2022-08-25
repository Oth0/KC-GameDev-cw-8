using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform groundPos;
    public float speed;
    public float rad;
    public LayerMask groundLayer;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyPatrol();
    }

    void EnemyPatrol()
    {
        rb.velocity = new Vector2(speed, 0f);
        bool isGrounded = Physics2D.OverlapCircle(groundPos.position, rad, groundLayer);

        if (!isGrounded)
        {
            speed *= -1;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);   
        }
    }
}

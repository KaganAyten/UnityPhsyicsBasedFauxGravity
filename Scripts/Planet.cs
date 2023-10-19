using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{ 
    [SerializeField] private Rigidbody2D player; 
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        EffectGravity();
    }
    private void EffectGravity( )
    {
        Vector2 dir = rb.position - player.position;

        float distance = dir.magnitude;
        float forceMag = (rb.mass * player.mass) / Mathf.Pow(distance, 2);

        Vector2 force = dir.normalized * forceMag;
        player.transform.up = -dir;
        player.AddForce(force);
    }
}

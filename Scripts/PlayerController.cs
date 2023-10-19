using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed; 
    private Rigidbody2D rb;
    private float horInput; 
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    } 
    private void Update()
    {
        horInput = Input.GetAxis("Horizontal"); 
    } 
    private void FixedUpdate()
    {
        var velocity = transform.right * movementSpeed*horInput;
        rb.velocity = velocity; 
    }
}

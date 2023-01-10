using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2Dplayer : MonoBehaviour
{
    public float MoveSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D rb;
    public Camera cam;
    // Start is called before the first frame update
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MoveSpeed;
        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
           
        }
        if(Input.GetButtonDown("Jump")&& Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            Debug.Log("sa");
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }
}

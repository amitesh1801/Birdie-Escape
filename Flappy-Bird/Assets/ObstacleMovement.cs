using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D col;
    private float x=3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        rb.velocity = new Vector2(-x, 0);
        
    }
   
    // Update is called once per frame
    void Update()
    {
      if(transform.position.x<(-13f))
            Destroy(this.gameObject);
    }
}

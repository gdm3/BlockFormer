

using System.Collections.ObjectModel;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
public class Movement : MonoBehaviour
{

    public int jumps = 0;
    public Rigidbody2D rb;
    private bool isCollidingWithWall = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
            if (jumps < 2)
            {
                rb.velocity = new Vector2(rb.velocity.x, 5);
                jumps++;
            }
            if(isCollidingWithWall == true)
            {
                rb.velocity = new Vector2(rb.velocity.x, 5);
                jumps = 1;
            }

        }
        if(Input.GetKey("d"))
        {
            rb.velocity += new Vector2(.15f, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity += new Vector2(-.15f, 0);
        }
        rb.velocity = new Vector2(rb.velocity.x * 0.965f, rb.velocity.y);
    
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Lava"){
            Debug.Log("Lava");
            gameObject.transform.position = new Vector2(-6, -2.7f);
        }
        if (col.gameObject.tag == "Sides")
        {
            Debug.Log("Wall");
            isCollidingWithWall = true;
        }
        jumps = 0;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Sides")
        {
            Debug.Log("Wall");
            isCollidingWithWall = false;
        }
    }

}

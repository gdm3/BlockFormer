

using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
public class Movement : MonoBehaviour
{


    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        if(Input.GetKey("d"))
        {
            rb.velocity += new Vector2(.25f, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity += new Vector2(-.25f, 0);
        }
        rb.velocity = new Vector2(rb.velocity.x * 0.965f, rb.velocity.y);

    }
}

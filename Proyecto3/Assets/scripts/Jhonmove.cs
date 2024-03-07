using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {

        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);

    }


}

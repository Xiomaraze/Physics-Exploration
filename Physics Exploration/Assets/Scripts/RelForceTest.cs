using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelForceTest : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 force = Vector2.left;
    Rigidbody2D rigBody;
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigBody.AddRelativeForce(force);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    bool onground = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && onground)
        {
            rb.AddForce(0, 30, 0);
            onground = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.position = new Vector3(tf.position.x - 0.3f, tf.position.y, tf.position.z);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Cube (1)")
        {
            onground = true;
        }
    }
}

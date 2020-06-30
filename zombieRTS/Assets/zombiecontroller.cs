using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiecontroller : MonoBehaviour
{
    public GameObject player;
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tf.position.x < player.transform.position.x)
        {
            tf.position = new Vector3(tf.position.x + 1, tf.position.y, tf.position.z);
        }
        else if (tf.position.x > player.transform.position.x)
        {
            tf.position = new Vector3(tf.position.x - 1, tf.position.y, tf.position.z);
        }

        if (tf.position.y < player.transform.position.y)
        {
            tf.position = new Vector3(tf.position.x, tf.position.y + 1, tf.position.z);
        }
        else if (tf.position.y > player.transform.position.y)
        {
            tf.position = new Vector3(tf.position.x, tf.position.y - 1, tf.position.z);
        }
    }
}

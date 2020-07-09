using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiecontroller : MonoBehaviour
{
    public GameObject player;
    public Transform tf;
    public SpriteRenderer zrnd;
    public Sprite zm2;
    public Sprite zm1;
    float speed;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        zrnd.sprite = zm1;
        speed = 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;
        if (counter > 25)
        {
            if (zrnd.sprite == zm1)
            {
                zrnd.sprite = zm2;
            }
            else
            {
                zrnd.sprite = zm1;
            }

            counter = 0;
        }

        //Debug.Log(player.GetComponent<RectTransform>().rect.center.x);
        if (tf.position.x < player.transform.position.x - 5)
        {
            tf.position = new Vector3(tf.position.x + speed, tf.position.y, tf.position.z);
        }
        else if (tf.position.x > player.transform.position.x)
        {
            tf.position = new Vector3(tf.position.x - speed, tf.position.y, tf.position.z);
        }

        if (tf.position.y < player.transform.position.y - 5)
        {
            tf.position = new Vector3(tf.position.x, tf.position.y + speed, tf.position.z);
        }
        else if (tf.position.y > player.transform.position.y)
        {
            tf.position = new Vector3(tf.position.x, tf.position.y - speed, tf.position.z);
        }
    }
}

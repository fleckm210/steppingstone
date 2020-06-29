using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class mousecontroller : MonoBehaviour
{
    public GameObject Button;
    private Transform btf;
    public Transform tf;
    public buttoncontroller bc;
    // Start is called before the first frame update
    void Start()
    {
        btf = Button.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bc.StartFollowing)
        {
            tf.position = Input.mousePosition;
        }
        else
        {
            tf.position = new Vector3(Input.mousePosition.x + 500, Input.mousePosition.y + 500, Input.mousePosition.z);
        }
    }

    public void Click()
    {
        btf.position = tf.position;

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            bc.StartFollowing = false;
        }
    }
}

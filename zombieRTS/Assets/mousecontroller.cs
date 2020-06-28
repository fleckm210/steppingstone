using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class mousecontroller : MonoBehaviour
{
    public GameObject Button;
    private Transform btf;
    public Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        btf = Button.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position = Input.mousePosition;
    }

    public void Click()
    {
        btf.position = tf.position;
    }
}

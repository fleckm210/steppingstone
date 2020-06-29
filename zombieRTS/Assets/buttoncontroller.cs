using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncontroller : MonoBehaviour
{
    public Transform tf;
    public bool StartFollowing = false;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("has clicked");
        StartFollowing = true;
    }

    
}

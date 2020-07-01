using UnityEngine;

public class mousecontroller : MonoBehaviour
{
    public GameObject Button;
    private Transform btf;
    public Transform tf;
    public buttoncontroller bc;
    Vector3 mpos;

    // Start is called before the first frame update
    void Start()
    {
        btf = Button.GetComponent<Transform>();
        mpos = Input.mousePosition;
    }


    private void Update()
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

    // Update is called once per frame
    void FixedUpdate()
    {

        if (bc.StartFollowing)
        {
            

            if (btf.position.x < mpos.x - 4)
            {
                btf.position = new Vector3(btf.position.x + 6, btf.position.y, btf.position.z);
            }
            else if (btf.position.x > mpos.x + 4)
            {
                btf.position = new Vector3(btf.position.x - 6, btf.position.y, btf.position.z);
            }

            if (btf.position.y < mpos.y - 4)
            {
                btf.position = new Vector3(btf.position.x, btf.position.y + 6, btf.position.z);
            }
            else if (btf.position.y > mpos.y + 4)
            {
                btf.position = new Vector3(btf.position.x, btf.position.y - 6, btf.position.z);
            }

        }
    }

    public void Click()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            bc.StartFollowing = false;
        }

        mpos = Input.mousePosition;
    }
}

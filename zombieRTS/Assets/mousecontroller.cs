using UnityEngine;

public class mousecontroller : MonoBehaviour
{
    public GameObject Button;
    private Transform btf;
    public Transform tf;
    public buttoncontroller bc;
    Vector3 mpos = Input.mousePosition;

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

        if (bc.StartFollowing)
        {
            

            if (btf.position.x < mpos.x)
            {
                btf.position = new Vector3(btf.position.x + 6, btf.position.y, btf.position.z);
            }
            else if (btf.position.x > mpos.x)
            {
                btf.position = new Vector3(btf.position.x - 6, btf.position.y, btf.position.z);
            }

            if (btf.position.y < mpos.y)
            {
                btf.position = new Vector3(btf.position.x, btf.position.y + 6, btf.position.z);
            }
            else if (btf.position.y > mpos.y)
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

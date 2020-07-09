using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Controller : MonoBehaviour
{
    public GameObject camObj;
    Camera mainCam;
    public Transform playerTF;
    Vector3 playerScreenPos;
    Vector3 newPosition; //where the player is going next
    public RectTransform HealthBarScale;
    public GameObject healthbar;

    // Start is called before the first frame update
    void Start()
    {
        HealthBarScale = healthbar.GetComponent<RectTransform>();

        mainCam = camObj.GetComponent<Camera>();

        //Debug.Log(mainCam.WorldToScreenPoint(new Vector3(0, 0, 0)));

        playerScreenPos = mainCam.WorldToScreenPoint(playerTF.position);

        //Make the new position start as the current player position
        newPosition = playerTF.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Left click is held down
        if (Input.GetMouseButton(0))
        {
            //Debug.Log(Input.mousePosition.x);
            //Debug.Log(playerScreenPos.x);

            //tell the player where to go next

            //covert mouse position into world postion
            newPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);

            //have the player move to new position


        }
    }//END OF Update

    private void FixedUpdate()
    {

        if (playerTF.position.x < newPosition.x - 4)
        {
            playerTF.position = new Vector3(playerTF.position.x + 6, playerTF.position.y, playerTF.position.z);
        }
        else if (playerTF.position.x > newPosition.x + 4)
        {
            playerTF.position = new Vector3(playerTF.position.x - 6, playerTF.position.y, playerTF.position.z);
        }

        if (playerTF.position.y < newPosition.y - 4)
        {
            playerTF.position = new Vector3(playerTF.position.x, playerTF.position.y + 6, playerTF.position.z);
        }
        else if (playerTF.position.y > newPosition.y + 4)
        {
            playerTF.position = new Vector3(playerTF.position.x, playerTF.position.y - 6, playerTF.position.z);
        }
    }//END OF FixedUpdate

    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.name == "zombie")
        {
            HealthBarScale.localScale = new Vector3(HealthBarScale.localScale.x, HealthBarScale.localScale.y, HealthBarScale.localScale.z);
        }
    }
}

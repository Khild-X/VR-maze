using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class buttonTrigger : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject button;
    public string coordinate;
    bool isPressed;
    float startPosZ;
    float startPosY;
    float startPosX;

    void Start()
    {
        startPosZ = button.transform.position.z;
        startPosY = button.transform.position.y;
        startPosX = button.transform.position.x;
    }
    void OnTriggerEnter()
    {
        if(gameObj!=null)
            gameObj.SetActive(true);
        isPressed = true;
        
    }
    void Update()
    {
        if(coordinate=="x")
        {
            if (isPressed)
            {
                while (button.transform.position.x <= startPosX + 0.1f)
                {
                    button.transform.position += new Vector3(0.004f,0 , 0);
                    //Debug.Log("ButtonWorks");
                }
                isPressed = false;
                gameObject.GetComponent<CapsuleCollider>().enabled = false;

            }
            if (button.transform.position.x > startPosX)
            {
                button.transform.position -= new Vector3(0.004f, 0, 0);
            }
        }
        if (coordinate=="y")
        {
            if (isPressed)
            {
                while (button.transform.position.y <= startPosY + 0.1f)
                {
                    button.transform.position += new Vector3(0, 0.004f,0 );
                    //Debug.Log("ButtonWorks");
                }
                isPressed = false;

            }
            if (button.transform.position.y > startPosY)
            {
                button.transform.position -= new Vector3(0, 0.004f,0 );
            }
        }
        if (coordinate == "z")
        {
            if (isPressed)
            {
                while (button.transform.position.z >= startPosZ - 0.1f)
                {
                    button.transform.position -= new Vector3(0, 0, 0.005f);
                    //Debug.Log("ButtonWorks");
                }
                isPressed = false;

            }
            if (button.transform.position.z < startPosZ)
            {
                button.transform.position += new Vector3(0, 0, 0.005f);
            }
        }
    }
}

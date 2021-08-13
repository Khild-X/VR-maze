using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleportation : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter()
    {
        player.transform.position = new Vector3(78, 16, -3);
    }
}

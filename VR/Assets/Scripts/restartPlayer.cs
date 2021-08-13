using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y<-6)
            SceneManager.LoadScene("restart");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
       if(other.tag!="platform" && other.tag!="ball")
            SceneManager.LoadScene("Main");
    }
}

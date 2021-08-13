using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDisappearing : MonoBehaviour
{
    public GameObject cube;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.transform.position.y<4)
            time += Time.deltaTime;
        if (time > 4)
            cube.SetActive(false);
    }
}

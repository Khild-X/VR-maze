using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeswall : MonoBehaviour
{
    public GameObject leftSpikes;
    public GameObject rightSpikes;
    float leftSpikesPositionZ;
    float rightSpikesPositionZ;
    bool flagForLeftSpikes;
    bool flagForRightSpikes;
    // Start is called before the first frame update
    void Start()
    {
        leftSpikesPositionZ = leftSpikes.transform.position.z;
        rightSpikesPositionZ = rightSpikes.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(!flagForLeftSpikes)
        {
            while(leftSpikes.transform.position.z>leftSpikesPositionZ-2)
            {
                leftSpikes.transform.position += new Vector3(0, 0, 0.005f);
            }
            flagForLeftSpikes = true;
        }
        else
        {
            while (leftSpikes.transform.position.z < leftSpikesPositionZ)
            {
                leftSpikes.transform.position += new Vector3(0, 0, 0.005f);                
            }
            flagForLeftSpikes = false;
        }
    }
}

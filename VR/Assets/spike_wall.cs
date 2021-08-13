using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_wall : MonoBehaviour
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
        leftSpikesPositionZ = leftSpikes.transform.localPosition.z;
        rightSpikesPositionZ = rightSpikes.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (!flagForLeftSpikes)
        {
            while (leftSpikes.transform.localPosition.z > leftSpikesPositionZ - 2)
            {
                leftSpikes.transform.localPosition += new Vector3(0, 0, 0.005f);
            }
            flagForLeftSpikes = true;
        }
        else
        {
            while (leftSpikes.transform.localPosition.z < leftSpikesPositionZ)
            {
                leftSpikes.transform.localPosition += new Vector3(0, 0, 0.005f);
            }
            flagForLeftSpikes = false;
        }
    }
}

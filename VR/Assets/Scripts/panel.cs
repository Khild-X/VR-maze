using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public List<GameObject> buttonsList;
    List<string> pressedButtons;
    public GameObject door;
    public List<GameObject> shelf;
    void Start()
    {

        pressedButtons = new List<string>();
    }
    
    void Update()
    {
        foreach (var button in buttonsList)
        {
            
            if (button.transform.localPosition.x!= -1 && !pressedButtons.Contains(button.name)&& pressedButtons.Count<=3)
            {
                pressedButtons.Add(button.name);
                Debug.Log(button.name);
            }
            else if (pressedButtons.Count==3)
            {
                int rightAnswers = 0;
                foreach (var buttonNumber in pressedButtons)
                {
                    if (buttonNumber == "2" || buttonNumber == "6" || buttonNumber == "7")
                    {
                        rightAnswers += 1;
                    }
                    
                }
                if (rightAnswers == 3)
                {
                    door.transform.localPosition = new Vector3(30, door.transform.localPosition.y, door.transform.localPosition.z);
                    foreach(var item in shelf)
                        item.SetActive(true);
                }                
                rightAnswers = 0;                
                foreach (var number in pressedButtons)
                    buttonsList[int.Parse(number) - 1].transform.localPosition = new Vector3(-1, buttonsList[int.Parse(number) - 1].transform.localPosition.y, buttonsList[int.Parse(number) - 1].transform.localPosition.z);
                pressedButtons.Clear();

            }
        }

    }
}

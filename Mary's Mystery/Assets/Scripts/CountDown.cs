using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject text;
    public int secondsLeft = 60;
    public bool takingAway = false;

    void Start()
    {
        text.GetComponent<Text>().text = "0:" + secondsLeft;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(timer());
        }
    }

    IEnumerator timer()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);    
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            text.GetComponent<Text>().text = "0:0" + secondsLeft;
        }
        text.GetComponent<Text>().text = "0:" + secondsLeft;
        takingAway = false;
    }
}

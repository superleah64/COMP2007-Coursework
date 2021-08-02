using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("WKey"))
        {
            player.GetComponent<Animator>().Play("Walking");
        }

        if (Input.GetButtonDown("AKey"))
        {
            player.GetComponent<Animator>().Play("Walking");
        }

        if (Input.GetButtonDown("SKey"))
        {
            player.GetComponent<Animator>().Play("Walking");
        }

        if (Input.GetButtonDown("DKey"))
        {
            player.GetComponent<Animator>().Play("Walking");
        }

        if (Input.GetButtonDown("PickUp"))
        {
            player.GetComponent<Animator>().Play("PickUp");
        }
    }
}

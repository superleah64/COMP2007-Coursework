using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        // game starts with the player in the idle animation
        player.GetComponent<Animator>().Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {

        // if WASD keys are pressed, the walking animation is played
        if (Input.GetButtonDown("WKey")
        || Input.GetButtonDown("AKey")
        || Input.GetButtonDown("SKey")
        || Input.GetButtonDown("DKey"))

        {
            player.GetComponent<Animator>().Play("Walking");
        }

        // if the WASD keys are no longer pressed, the idle animation plays
        else if (Input.GetButtonUp("WKey")
        || Input.GetButtonUp("AKey")
        || Input.GetButtonUp("SKey")
        || Input.GetButtonUp("DKey"))
        {
            player.GetComponent<Animator>().Play("Idle");
        }

        // if the space key is pressed, the pickup animation is played
        if (Input.GetButtonDown("PickUp"))
        {
            player.GetComponent<Animator>().Play("PickUp");
        }

        else if (Input.GetButtonUp("PickUp"))
        {
            player.GetComponent<Animator>().Play("Idle");
        }
    }
}

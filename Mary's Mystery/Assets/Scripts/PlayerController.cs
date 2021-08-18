using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public AudioSource[] sound;

    Animator animator;
    int isWalkingHash;
    int isPickingUpHash;
    int isWPickingUpHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isPickingUpHash = Animator.StringToHash("isPickingUp");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isPickingUp = animator.GetBool(isPickingUpHash);
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("s");
        bool backPressed = Input.GetKey("d");
        bool spacePressed = Input.GetKey("space");

        // if WASD keys are pressed, the walking animation is played
        if (!isWalking && forwardPressed || leftPressed || rightPressed || backPressed)
        {
            animator.SetBool(isWalkingHash, true);
            sound[1].Play();
        }

        // if no buttons are pressed, walking animation is stopped
        if (isWalking && !forwardPressed && !leftPressed && !rightPressed && !backPressed)
        {
            animator.SetBool(isWalkingHash, false);
            sound[1].Stop();
        }

        if (!isWalking && spacePressed)
        {
            animator.SetBool(isPickingUpHash, true);
        }

        if (isWalking && spacePressed)
        {
            animator.SetBool(isPickingUpHash, true);
        }

        if (!spacePressed)
        {
            animator.SetBool(isPickingUpHash, false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    private bool pickUpAllowed;
    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gameController.collectable++;
    }

    void Update()
    {
        // space key triggers item pickup if player is near an item
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Space))
            PickUpObject();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = false;
        }
    }

    // calls the pickup method
    public void PickUpObject()
    {
        StartCoroutine(startPickUp());
    }

    public IEnumerator startPickUp()
    {
        // delay item from immediately being picked up to match up with the animation
        yield return new WaitForSeconds(0.9f);

        // destroys object
        Destroy(gameObject);
        gameController.collectable--;
    }
}
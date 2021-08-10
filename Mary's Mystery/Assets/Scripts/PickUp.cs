using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private bool pickUpAllowed;

    // space key triggers item pickup
    private void Update()
    {
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

    // plays sound effect and destroys object
    private void PickUpObject()
    {
        Destroy(gameObject);
    }

    IEnumerator startPickUp()
    {
        yield return new WaitForSeconds(1);
        PickUpObject();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int collectedItems = 0;

    public OpenDoor door;
    public OpenDoor1 door1;
    public OpenDoor2 door2;

    // Update is called once per frame
    void Update()
    {
        if (collectedItems >= 1)
        {
            door.OpenTheDoor();
        }
        if(collectedItems >= 2)
        {
            door1.OpenTheDoor1();
        }
        if (collectedItems >= 3)
        {
            door2.OpenTheDoor2();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Name of GO: " + collision.gameObject.name);

        if (collision.gameObject.tag == "Collectable")
        {
            collectedItems++;

            Destroy(collision.gameObject);
        }

    }

}

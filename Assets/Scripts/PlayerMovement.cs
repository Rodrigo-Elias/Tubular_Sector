using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Add the PlayerRotator Object here.
    [SerializeField]
    Transform playerRotator;
    [SerializeField]
    float shipSpeed = 100;


    // Update is called once per frame
    void FixedUpdate()
    {
        ShipRotation();
    }


    void ShipRotation() //rotation method of the ship on screen.
    {
        if (Input.GetKey("a"))
        {
            playerRotator.Rotate(0, 0, -shipSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            playerRotator.Rotate(0, 0, shipSpeed * Time.deltaTime);
        }
    }
}

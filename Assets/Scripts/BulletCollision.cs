using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    //for now, anythiing that collides with the bullet destroy it.
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}

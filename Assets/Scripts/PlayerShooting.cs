using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject projectileEmitter; // the empty object from where i shoot
    [SerializeField]
    GameObject Bullet; //what i shoot
    [SerializeField]
    float Bullet_Forward_Force = 80000f; //force i shoot

    //limits the ammount of bullets.
    [SerializeField]
    float FireRate = 0.1f;
    [SerializeField]
    float NextFire = 0f;



    void FixedUpdate()
    {

        if (Input.GetKeyDown("space") && Time.time > NextFire)
        {
            //validating fire rate.
            NextFire = Time.time + FireRate;

            //Bullet instance.
            GameObject Temporary_Bullet;
            Temporary_Bullet = Instantiate(Bullet, projectileEmitter.transform.position, projectileEmitter.transform.rotation) as GameObject;

            //Get RigidBody of Temporary_bullet
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet.GetComponent<Rigidbody>();

            //Push the RigidBody.
            Temporary_RigidBody.AddForce((transform.forward * Bullet_Forward_Force) * Time.deltaTime);

            //Basic Clean Up, set the Bullets to self destruct after X Seconds.
            Destroy(Temporary_Bullet, 4.0f);
            //Bullet also disappear if it collides with enemy. Script on bullet prefab.

        }

    }
}

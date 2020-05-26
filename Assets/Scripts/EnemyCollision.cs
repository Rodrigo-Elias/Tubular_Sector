using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    //script on child "enemy on rotator" but we add the EnemyRotator Object here
    public GameObject myRotator;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Player_Bullet")
        {
            Destroy(myRotator);
        }
    }
}

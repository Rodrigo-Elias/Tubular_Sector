using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform enemyRotator;
    [SerializeField]
    float shipSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        enemyRotator.Rotate(0, 0, shipSpeed * Time.deltaTime);
    }
}

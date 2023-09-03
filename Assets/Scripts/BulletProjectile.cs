using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The code of the script has been followed and inspired from a guide via this source: https://www.youtube.com/watch?v=FbM4CkqtOuA&ab_channel=CodeMonkey
// It has been tailored and modified in a way that suits the needs of the game at hand

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRigidbody;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 40f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Debug.Log(other + " object destroyed");
            Destroy(this.gameObject);
        }
        else 
        {
            Destroy(this.gameObject);
        }
            
    }


}

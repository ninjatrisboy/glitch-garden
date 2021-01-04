using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField ]float Speed = 5f;
    [SerializeField] float damage = 100;

    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
     {
         var health = otherCollider.GetComponent<Health>();
         health.DealDamage(damage);
     }

}

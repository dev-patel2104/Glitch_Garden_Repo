using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 20f)] [SerializeField] float projectileSpeed = 1f;
    [SerializeField] float damage;
    
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
        
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var Health = otherCollider.GetComponent<health>();
        var attacker = otherCollider.GetComponent<Attacker>();

        if(attacker && Health)
        {
            Health.DealDamage(damage);
            Destroy(gameObject);
        }
        
    }
}

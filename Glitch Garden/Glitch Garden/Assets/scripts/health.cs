using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] float Health = 100f;
    [SerializeField] GameObject DeathVFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(float damage)
    {
        Health = Health - damage;
        if(Health <= 0)
        {
            var VFX = Instantiate(DeathVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(VFX,0.3f);
        }
    }
}

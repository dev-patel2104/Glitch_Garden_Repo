using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject defenderTarget = otherCollider.gameObject;
        if(defenderTarget.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(defenderTarget);
        }
    }
}

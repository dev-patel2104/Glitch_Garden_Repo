using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject defender = otherCollider.gameObject;
        if (defender.GetComponent<graveStone>())
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }

        else if (defender.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(defender);
        }
    }
}

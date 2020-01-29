using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] bool spawn = true;
    [SerializeField] float minSpawnTimeDiff = 1f;
    [SerializeField] float maxSpawnTimeDiff = 5f;
    [SerializeField] Attacker[] attackerprefabArray;
    // Start is called before the first frame update
   IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTimeDiff, maxSpawnTimeDiff));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerprefabArray.Length);
        Spawn(attackerIndex);
    }

    private void Spawn(int myAttackerIndex)
    {
        Attacker newAttacker;
        newAttacker = Instantiate(attackerprefabArray[myAttackerIndex], transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
     void Update()
    {
        
    }
}

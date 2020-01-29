using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject EndLabel;
    [SerializeField] GameObject LoseLabel;
    [SerializeField] float WaitTime = 0f;
    [SerializeField] AudioClip WinClip;

    private void Start()
    {
        EndLabel.SetActive(false);
        LoseLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void HandleLoseCondition()
    {
        LoseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
    }

    private void Update()
    {
        if(levelTimerFinished && numberOfAttackers <=0)
        {
            Debug.Log("End Level now");
            StartCoroutine(HandleWinCondition()); 
        }
    }

    IEnumerator HandleWinCondition()
    {
        EndLabel.SetActive(true);
        Time.timeScale = 0;
        GetComponent<AudioSource>().PlayOneShot(WinClip);
        yield return new WaitForSeconds(WaitTime);
        FindObjectOfType<levelloader>().LoadNextScene();

    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}

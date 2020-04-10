using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update

  
    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();

    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("This is level timer in seconds")]
    [SerializeField] float levelTime = 20f;
    bool triggeredLevelFinished = false;


    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished)
        {
            return;
        }
        
            GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

            bool timeFinished = (Time.timeSinceLevelLoad >= levelTime);

            if (timeFinished)
            {
                FindObjectOfType<LevelController>().LevelTimerFinished();
                triggeredLevelFinished = true;

            }
        if(PlayerPrefsController.GetDifficulty() == 1)
        {
            levelTime = 30f;
        }

        if(PlayerPrefsController.GetDifficulty() == 2)
        {
            levelTime = 50f;
        }
    }
}

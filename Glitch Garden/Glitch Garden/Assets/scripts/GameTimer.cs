using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("This is level timer in seconds")]
    [SerializeField] float levelTime = 10f;
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
        
    }
}

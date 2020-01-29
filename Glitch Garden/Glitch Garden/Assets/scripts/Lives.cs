using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    float lives;
    Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void DecreaseLives()
    {
        lives--;

        if(lives <= 0)
        {
            UpdateDisplay();
            StartCoroutine(WaitForTime());
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(1);
        FindObjectOfType<LevelController>().HandleLoseCondition();
        
    }

}

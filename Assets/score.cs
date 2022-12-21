using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text ScoreTextComponent;  //Assign this in the inspector
    private int playerscore = 0;  //current score as an integer
    private float secondTimer = 0f;    //timer for counting to 1 second

    void Update()
    {
        secondTimer = secondTimer + Time.deltaTime;
        if (secondTimer >= 1f)
        {
            addScore();
            secondTimer = secondTimer - 1f;
        }
    }

    private void addScore()
    {
        playerscore++;
        ScoreTextComponent.text = playerscore.ToString();
    }
}





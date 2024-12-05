using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Slider CountdownBar;
    public GameEnding gameEnding;
    public float totaltime = 60f;
    public float timeremaining;
    // Start is called before the first frame update
    void Start()
    {
        timeremaining = totaltime;
        CountdownBar.value = totaltime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeremaining > 0)
        {
            timeremaining -= Time.deltaTime;
            CountdownBar.value = timeremaining;
        }
        else
        {
            gameEnding.CaughtPlayer();
        }
    }
}

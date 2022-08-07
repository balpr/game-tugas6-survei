using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerOver : MonoBehaviour
{
    public Text timerTxt;
    float timer;
    int timerinsec;

    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!(player.transform.position.y < -5f))
        {
            timer += Time.deltaTime;
            timerinsec = (int) timer % 60;
            timerTxt.text = "Survive time : " + timerinsec;
        }
        
    }
}

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameTimeTxt = null;

    private int minute = 0;
    private float seconds = 0f;

    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerController.isGameOver)
        {
            seconds += Time.deltaTime;
            if(seconds >= 59)
            {
                seconds = 0;
                minute++;
            }
            gameTimeTxt.SetText(minute.ToString().Length>1?minute.ToString():"0" + minute.ToString() + ":" + (((int)seconds).ToString().Length > 1 ? ((int)seconds).ToString() : "0" + ((int)seconds).ToString()));

        }
    }
}

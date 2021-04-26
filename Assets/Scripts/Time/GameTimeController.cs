using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeController : MonoBehaviour
{
    [SerializeField] List<GameObject> iTimesObjects;
    private List<ITime> iTimes = new List<ITime>();
    public int minutes = 0;
    public int hours = 0;

    // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster
    public float clockSpeed = 1.0f;    

  
    int seconds;
    float msecs;

    private void Awake()
    {
        foreach(var obj in iTimesObjects)
        {
            iTimes.Add(obj.GetComponent<ITime>());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        msecs = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        msecs += Time.deltaTime * clockSpeed;
        if (msecs >= 1.0f)
        {
            msecs -= 1.0f;
            seconds++;
            if (seconds > 59)
            {
                seconds = 0;
                minutes++;
                if (minutes > 59)
                {
                    minutes = 0;
                    hours++;
                    if (hours > 23)
                        hours = 0;
                }
            }
        }
        foreach(var item in iTimes)
        {
            item.ApplyNewTime(seconds, minutes, hours);
        }
    }
}

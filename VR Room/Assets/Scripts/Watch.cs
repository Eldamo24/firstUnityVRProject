using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Watch : MonoBehaviour
{
    private DateTime actualHour;
    [SerializeField] private Transform hoursNeedle;
    [SerializeField] private Transform minutesNeedle;    
    [SerializeField] private Transform secondsNeedle;
    private float hourDegrees = 30f;
    private float minutesAndSecondsDegrees = 6f;
    private float clockOffset = 90f;

    void Update()
    {
        ClockHourUpdate();
    }
    
    private void ClockHourUpdate()
    {
        actualHour = DateTime.Now;
        hoursNeedle.localRotation = Quaternion.Euler(clockOffset + actualHour.Hour * hourDegrees, hoursNeedle.localRotation.y, -90f);
        minutesNeedle.localRotation = Quaternion.Euler(clockOffset + actualHour.Minute * minutesAndSecondsDegrees, minutesNeedle.localRotation.y, -90f);
        secondsNeedle.localRotation = Quaternion.Euler(clockOffset + actualHour.Second * minutesAndSecondsDegrees, secondsNeedle.localRotation.y, -90f);
    }
        
}

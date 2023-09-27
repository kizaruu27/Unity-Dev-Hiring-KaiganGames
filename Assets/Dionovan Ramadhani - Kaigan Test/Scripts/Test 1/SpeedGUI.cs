using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedGUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentSpeedTxt;
    [SerializeField] TextMeshProUGUI maxSpeedTxt;
    [SerializeField] TextMeshProUGUI forwardAccelerationTxt;
    [SerializeField] TextMeshProUGUI brakeDecelerationSpeedTxt;

    [SerializeField] private Controller _controller;

    // Start is called before the first frame update

    private void Update()
    {
        float currentSpeed = _controller.currentSpeed;
        string speedString = string.Format("{0:F0}", currentSpeed);

        currentSpeedTxt.text = speedString + "m/s";
        maxSpeedTxt.text = "Max Speed: " + _controller.maxSpeed.ToString() + "m/s";
        forwardAccelerationTxt.text = "Forward Acceleration: " + _controller.maxSpeed.ToString() + "m/s";
        brakeDecelerationSpeedTxt.text = "Brake Deceleration: " + _controller.brakeAcceleration.ToString() + "m/s";
    }
}

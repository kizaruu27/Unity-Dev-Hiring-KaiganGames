using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public enum EngineState
{
    Accelerate,
    Idle,
    Brake
}

public class Controller : MonoBehaviour
{
    [Header("Engine State Enum")]
    [SerializeField] EngineState engineState;
    
    [Header("Vehicle Value")]
    [SerializeField] private float distanceToTarget;
    public float forwardAcceleration = 10f;
    public float brakeAcceleration = 5f;
    public float maxSpeed = 15f;
    [HideInInspector] public float currentSpeed;

    [Header("Target Transform")]
    [SerializeField] private Transform targetTransform;

    #region UnityMethods
    private void Start()
    {
        engineState = EngineState.Accelerate;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        
        DetermineEngineState(distanceToTarget, currentSpeed, maxSpeed, targetTransform);
        CalculateEngine();
    }
    #endregion

    #region Private Methods
    void DetermineEngineState(float distanceToTarget, float currentSpeed, float maxSpeed, Transform target)
    {
        if (currentSpeed == maxSpeed)
            engineState = EngineState.Idle;
        
        if (Vector3.Distance(transform.position, target.position) < distanceToTarget)
            engineState = EngineState.Brake;

    }

    void CalculateEngine()
    {
        if (engineState == EngineState.Accelerate)
        {
            currentSpeed += forwardAcceleration * Time.deltaTime;
            if (currentSpeed >= maxSpeed)
                currentSpeed = maxSpeed;
        }
        
        if (engineState == EngineState.Brake)
        {
            currentSpeed -= brakeAcceleration * Time.deltaTime;
        }

        if (transform.position.z >= targetTransform.position.z || currentSpeed == 0)
            currentSpeed = 0;
    }
    #endregion


}

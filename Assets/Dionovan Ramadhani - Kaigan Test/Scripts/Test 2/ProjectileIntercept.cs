using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileIntercept : MonoBehaviour
{
    public bool CalculatInterceptPosition(Vector3 selfPosition, Vector3 selfVelocity, Vector3 targetPosition, 
        Vector3 targetVelocity, float bulletSpeed, out Vector3 interceptPosition)
    {
        Vector3 relativeVelocity = targetVelocity - selfVelocity;
        
        Vector3 relativePosition = targetPosition - selfPosition;
        
        float timeToIntercept = relativePosition.magnitude / (bulletSpeed - relativeVelocity.magnitude);
        
        if (timeToIntercept >= 0 && timeToIntercept < float.MaxValue)
        {
            interceptPosition = targetPosition + targetVelocity * timeToIntercept;
            return true;
        }
        else
        {
            interceptPosition = Vector3.zero;
            return false;
        }
    }
}

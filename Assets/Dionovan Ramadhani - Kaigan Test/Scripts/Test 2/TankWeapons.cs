using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TankWeapons : MonoBehaviour
{
    [SerializeField] private Projectiles projectilePrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private ProjectileIntercept intercept;
    [SerializeField] private TankController controller;
    [SerializeField] private TankController target;
    [SerializeField] private TextMeshProUGUI UIPanel;
    void Start()
    {
       Shoot();
    }

    void Shoot()
    {
        Projectiles projectiles = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        Vector3 interceptPosition;
        bool canIntercept = intercept.CalculatInterceptPosition(controller.transform.position, controller.velocity,
            target.transform.position, target.velocity, projectiles.projectileSpeed, out interceptPosition);

        if (canIntercept)
            UIPanel.text = "Intercept is possible";
        else
            UIPanel.text = "Intercept is not possible";
    }
    
}

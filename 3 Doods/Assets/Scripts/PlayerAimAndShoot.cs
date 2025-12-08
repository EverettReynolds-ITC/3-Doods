using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAimAndShoot : MonoBehaviour
{
    [SerializeField] private GameObject gun;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    private GameObject bulletInst;
    private Vector2 worldPosition;
    private Vector2 direction;
    private const int stoppery = -5;
    // Arrrow UI / levels
    private int aCount = 3, eCount = 2;
    private int activeLevel = 1;
    [SerializeField] private GameObject arrow1, arrow2, arrow3, arrow4, arrow5, level1, level2, level3;
    private List<GameObject> arrows = new List<GameObject> { }, levels = new List<GameObject> { }, 
        level1Enemies = new List<GameObject> { };
    private void Start()
    {
        arrows.Add(arrow1);
        arrows.Add(arrow2);
        arrows.Add(arrow3);
        arrows.Add(arrow4);
        arrows.Add(arrow5);
        levels.Add(level1);
        levels.Add(level2);
        levels.Add(level3);
    }
    private void Update()
    {
        HandleGunRotation();
        HandleGunShooting();
    }
    private void HandleGunRotation()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (worldPosition.y > stoppery)
        {
            direction = (worldPosition - (Vector2)gun.transform.position).normalized;
            gun.transform.right = direction;
        }
    }
    private void HandleGunShooting()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && aCount != 0)
        {
            bulletInst = Instantiate(bullet, bulletSpawnPoint.position, gun.transform.rotation);
            arrowCount(ref aCount);
        }
    }
    private void arrowCount(ref int Count)
    {
        arrows[Count - 1].SetActive(false);
        Count--;
    }
    public void checkForWin()
    {
        
        if (eCount == 0)
        {
            levels[activeLevel - 1].SetActive(false);
            activeLevel++;
            levels[activeLevel - 1].SetActive(true);
            if (activeLevel == 2)
            {
                aCount = 4;
                eCount = 4;
                for (int i = 0; i < aCount; i++)
                {
                    arrows[i].SetActive(true);
                }

            }
        }
        else if (aCount == 0)
        {
            //lose function here
        }
    }
    public void enemyDepleter()
    {
        eCount--;
        checkForWin();
    }
}

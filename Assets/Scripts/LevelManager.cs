using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject target;
    public TargetScan targetScan;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPos.z = 0;
            Instantiate(target, worldPos, Quaternion.identity);

            
            //FireBullet();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            targetScan.DetectTargets();
        }
    }

}

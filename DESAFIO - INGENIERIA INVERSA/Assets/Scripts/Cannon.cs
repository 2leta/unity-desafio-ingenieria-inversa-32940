using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ Shoot();
        }
        if(Input.GetKeyDown(KeyCode.J)){doubleshoot(); }
    if(Input.GetKeyDown(KeyCode.K)){tripleshoot(); }
    if(Input.GetKey(KeyCode.L)){HoldShoot(); } 
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
private void doubleshoot()
{ if(canShoot)
{ canShoot=false;
Invoke("bulletinvoker",0.3f);
Invoke("bulletinvoker",0.8f);
Invoke ("ResetShoot",1f);
}}
    private void ResetShoot()
    {
        canShoot = true;
    }
    private void bulletinvoker(){
        Instantiate(munition, transform);
    }
    private void tripleshoot(){
        if(canShoot){
            canShoot=false;
            Invoke ("bulletinvoker",0.3f);
            Invoke ("bulletinvoker",0.8f);
            Invoke ("bulletinvoker",1.1f);
            Invoke ("ResetShoot",1.5f);
        }}
        private void HoldShoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 0.3f);
        }
    }
}

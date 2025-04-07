using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class PlayerShoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float FireRate = 3;
    public float TimeReload = 0;
    public bool Shooting;
    public ShootingMode shootingMode = ShootingMode.Default;
    
    
    
    public enum ShootingMode
    {
        Default = 0, 
        Fast,
        Spread,
        count
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUP powerup = collision.GetComponent<PowerUP>();
        if (powerup != null)
        {
            shootingMode = powerup.powerupshootmode;
            Destroy(collision.gameObject);

        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shooting = Input.GetKey(KeyCode.Space);
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            shootingMode = ShootingMode.Default;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            shootingMode = ShootingMode.Fast;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
                shootingMode = ShootingMode.Spread;
        }
        if(shootingMode == ShootingMode.Default)
        {
            BasicShootingPattern();
        } else if (shootingMode == ShootingMode.Fast)
        {
            FastShootingPattern();
        } else if (shootingMode == ShootingMode.Spread)
        {
            SpreadShootingPattern();
        }
         
        
    
    
    
    }
    void BasicShootingPattern()
    {

        FireRate = 3;
        if (Shooting && TimeReload <= 0)
        {
            Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            float SecondsperShot = 1 / FireRate;
            TimeReload = SecondsperShot;
        }


        TimeReload -= Time.deltaTime;
        if (TimeReload < 0)
        {
            TimeReload = 0;
        }

    }
    void FastShootingPattern()
    {
        FireRate = 9;
        if (Shooting && TimeReload <= 0)
        {
            Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            float SecondsperShot = 1 / FireRate;
            TimeReload = SecondsperShot;
        }

        ;
        TimeReload -= Time.deltaTime;
        if (TimeReload < 0)
        {
            TimeReload = 0;
        }
    }
    void SpreadShootingPattern()
    {

        
       
        if (Shooting && TimeReload <= 0)
        {
            FireRate = 3;
            Vector3 eulerRotation = transform.rotation.eulerAngles;

            Instantiate(ProjectilePrefab, transform.position, 
                Quaternion.Euler(eulerRotation.x, eulerRotation.y , eulerRotation.z + 7));
            Instantiate(ProjectilePrefab, transform.position,
                Quaternion.Euler(eulerRotation.x, eulerRotation.y, eulerRotation.z));
            Instantiate(ProjectilePrefab, transform.position,
                Quaternion.Euler(eulerRotation.x, eulerRotation.y , eulerRotation.z - 7));
            float SecondsperShot = 1 / FireRate;
            TimeReload = SecondsperShot;
        }

        
        TimeReload -= Time.deltaTime;
        if (TimeReload < 0)
        {
            TimeReload = 0;
        }




    }
    
}





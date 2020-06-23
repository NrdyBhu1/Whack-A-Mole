using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Variables
    public GameObject molePrefab;
    public float StrtTmeBtwSpwn = 3f;
    public float TmeBtwSpwn = 0.1f;
    #endregion
    
    void FixedUpdate()
    {
        if (TmeBtwSpwn <= 0){
            Instantiate( molePrefab, transform.position, Quaternion.identity);
            TmeBtwSpwn = StrtTmeBtwSpwn;
            StrtTmeBtwSpwn -= 0.025f;
        }else{
            TmeBtwSpwn -= Time.deltaTime;
        }
    }
}

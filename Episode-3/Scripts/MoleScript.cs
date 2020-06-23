using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    #region Variables

    public float waitSeconds = 1f;
    #endregion
    
    void Start()
    {
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitSeconds);
        Destroy(gameObject);
    }
}

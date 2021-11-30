using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float seconds;

    private IEnumerable<Superpower> powers;
    private void Awake() 
    {
        powers = GetComponents <Superpower>();    
    }

    private void Start()
    {
        StartCoroutine (ActivatePowers());
    }

    private IEnumerator ActivatePowers() 
    {
        YieldInstruction wfs = new WaitForSeconds(seconds);

        while (true) 
        { 
            foreach (Superpower sp in powers) 
            {
                sp.Activate();
            
            }

            yield return wfs; 
        
        }
    
    }
}

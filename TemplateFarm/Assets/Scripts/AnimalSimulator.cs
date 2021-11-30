using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSimulator
{
    private IEnumerator<AnimalsAI> AnimalAIs;

    private void Awake() 
    { 
        AnimalAIs = new AnimalsAI[] { new SheepAI(), new WolfAI() }
    
    }

    private void start() 
    { 

    }

    private IEnumerator TurnTime()
    {
        while () 
        {
            YieldInstruction wfs = new WaitForSeconds(2);

            foreach (AnimalsAI al  AnimalAIs)
            {
                al.TakeTurn();
            
            }

            yield return wfs;
        
        }


    }
}

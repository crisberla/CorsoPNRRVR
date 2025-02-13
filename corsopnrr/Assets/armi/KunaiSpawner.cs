using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private gameobjet proiettile;

    [SerializeField]
    private InputActionReference shootAction;
   
    [SerializeField]
    private transform firepoint;
    

    // Update is called once per frame
    void Update()
    {
        if(shootAction.action.WassPressedThisFrame())
        {
            instantiate(proiettile,firepoint.position,firepoint.rotation)
        }
    }
}

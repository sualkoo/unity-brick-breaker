using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brick;
    public GameObject brick2;
    async void Start()
    {
        for(int i = 0; i<6; i++)
        {
            Instantiate(brick, new Vector3(-5 + 2*i,4), Quaternion.identity);   
        }
        for(int i = 0; i<6; i++)
        {
            Instantiate(brick2, new Vector3(-5 + 2*i,3), Quaternion.identity);   
        }        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxchange : MonoBehaviour
{
    public Material s1;
    public Material s2;
    public bool skycheck = false;
    
    public void OnButtonClick()
    {
        skycheck = !skycheck;

        if (skycheck == true)
        {
            RenderSettings.skybox = s2;
        }
        else
        {
            RenderSettings.skybox = s1;
        }
    }
    
}

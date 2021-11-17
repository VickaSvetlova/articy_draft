using System.Collections;
using System.Collections.Generic;
using Articy.Unity;
using UnityEngine;

public class MyArticyPluginComponent : MonoBehaviour
{
    public ArticyRef myFirstArticyModel;

    void Start()
    {
        {
            var techName = myFirstArticyModel.GetObject().TechnicalName;
            Debug.Log(techName);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapReveal1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool showMap;
    void Start()
    {
        if (showMap)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

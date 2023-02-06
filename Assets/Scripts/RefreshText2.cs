using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshText2 : MonoBehaviour
{
    public TMPro.TMP_Text refreshtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        refreshtime.text = "" + GameManager.instance.GetTime().ToString("0.00"); 
    }
}

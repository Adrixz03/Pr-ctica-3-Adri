using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshText : MonoBehaviour
{
    public TMPro.TMP_Text refresh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        refresh.text = "Points: " + GameManager.instance.GetPunt(); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class TestHourIndicator : MonoBehaviour {

    public float Radius = 4;

    public GameObject go;

    public float includedAngle = 30;

    int count =0;

    void Start()
    {
        
    }
   

    void OnGUI()
    {

        if (GUILayout.Button("排列"))
        {
            SetHourIndicator();
        }
    }

    	
    void SetHourIndicator()
    {
        for (int i = 1; i < 12; i++)
        {
            var tmp = GameObject.Instantiate(go, this.transform);
            tmp.transform.localEulerAngles = new Vector3(0, i * 30, 0);
            float tmpz = Mathf.Sin(Mathf.Deg2Rad*(90 - i * 30));
            float z = tmpz * Radius;
           
//            float z = Mathf.Sin(90 - i * 30) * Radius;
            float x = Mathf.Cos(Mathf.Deg2Rad*(90 -i * 30)) * Radius;
            tmp.transform.position = new Vector3(x, 0.2f, z);
            tmp.name = go.name + i.ToString();
        }


    }




}

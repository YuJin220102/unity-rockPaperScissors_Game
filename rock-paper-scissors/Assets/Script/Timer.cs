using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Timer_txt;
    static public float num;
    // Start is called before the first frame update
    void Start()
    {
        num = 11f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer_txt.GetComponent<Text>().text = Mathf.Floor(num).ToString();
        num -= Time.deltaTime;
    }
}

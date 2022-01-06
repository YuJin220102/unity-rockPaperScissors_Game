using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    // Level Slider
    public Slider slLv;
    //Level text and count
    public Text Level1;
    public Text Level2;
    static public int BestLv;
    int num1 = 1;
    int num2 = 2;

    void Start() {
        slLv = GetComponent<Slider>();
        Level1.GetComponent<Text>().text = num1.ToString();
        Level2.GetComponent<Text>().text = num2.ToString();
    }
    private void Update() {
        //Gauge Up
        LevelUp();
        // Level up when you collect the gauges
        if(slLv.value == 1f){
            num1++;
            num2++;
            Level1.GetComponent<Text>().text = num1.ToString();
            Level2.GetComponent<Text>().text = num2.ToString();
            BestLv = num1;
            // Gauge initialization
            slLv.value = 0f;
            ColorTEST.LevelUp = 0f;
        }
    }
    public void LevelUp(){
        slLv.value = ColorTEST.LevelUp;
    }
}

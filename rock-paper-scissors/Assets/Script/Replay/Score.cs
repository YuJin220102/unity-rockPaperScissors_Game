using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "Lv" + Level.num1 +". " + (ChangeColor.LevelUp * 100) +"%";
    }
}

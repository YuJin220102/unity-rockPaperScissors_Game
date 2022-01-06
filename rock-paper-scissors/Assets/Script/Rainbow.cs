using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rainbow : MonoBehaviour
{
    float time1 = 255f; // RGB 255 -> 0 color
    float time2 = 0; // RGB 0 -> 255 color
    int count; // The order of colors
    void Start() {
        count = 0;
    }
    // Change colors up, down, left, right
    void Update()
    {
        if(count == 0){
            time1 -= Time.deltaTime * 50;
            if(time1 >= 0f){
                GetComponent<Image>().color = new Color(Mathf.Floor(time1)/255f, 225/255f, 0/255f, 255/255f);
            }
            if(Mathf.Floor(time1) <= 1f){
                count++;
                Debug.Log(count);
            }
        }
        if(count == 1){
            time2 += Time.deltaTime * 50;
            if(time2 <= 255f){
                GetComponent<Image>().color = new Color(0/255f, 225/255f, Mathf.Floor(time2)/255f, 255/255f);
                }
            if(Mathf.Floor(time2) >= 254f){
                count++;
                time1 = 255f;
                Debug.Log(count);
            }
        }
        if(count == 2){
            time1 -= Time.deltaTime * 50;
            if(time1 >= 0f){
                GetComponent<Image>().color = new Color(0/255f, Mathf.Floor(time1)/255f, 255/255f, 255/255f);
            }
            if(Mathf.Floor(time1) <= 1f){
                count++;
                time2 = 0; 
                Debug.Log(count);
            }
        }
        if(count == 3){
            time2 += Time.deltaTime * 50;
            if(time2 <= 255f){
                GetComponent<Image>().color = new Color(Mathf.Floor(time2)/255f, 0/255f, 255/255f, 255/255f);
            }
            if(Mathf.Floor(time2) >= 254f){
                count++;
                time1 = 255f;
                Debug.Log(count);
            }
        }
        if(count == 4){
            time1 -= Time.deltaTime * 50;
            if(time1 >= 0f){
                GetComponent<Image>().color = new Color(255/255f, 0/255f,  Mathf.Floor(time1)/255f, 255/255f);
            }
            if(Mathf.Floor(time1) <= 1f){
                count++;
                time2 = 0; 
                Debug.Log(count);
            }
        }
        if(count == 5){
            time2 += Time.deltaTime * 50;
            if(time2 <= 255f){
                GetComponent<Image>().color = new Color(255/255f, Mathf.Floor(time2)/255f, 0/255f, 255/255f);
            }
            if(Mathf.Floor(time2) >= 254f){
                count = 0;
                time1 = 255f;
                time2 = 0f;
                Debug.Log(count);
            }
        }

    }
}


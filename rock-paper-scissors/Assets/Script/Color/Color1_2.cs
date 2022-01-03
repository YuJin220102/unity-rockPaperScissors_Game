using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Color1_2 : MonoBehaviour
{
    public GameObject a;
    bool ok;
    private void Update() {
        if(a.transform.position == new Vector3(-1.54f, 2.31f, 0))ok = true;
        else{
            ok = false;
            GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
        }
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(ok == true){
            GetComponent<Image>().color = new Color(255/255f, 160/255f, 160/255f, 255/255f);
        }
    }
}


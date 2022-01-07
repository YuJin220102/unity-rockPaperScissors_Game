using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BEST : MonoBehaviour
{
    public Text Best;
    // Start is called before the first frame update
    void Start()
    {
        Best.GetComponent<Text>().text = "BEST : " + Level.BestLv.ToString();
    }
}

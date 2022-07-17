using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public int bodyCount = 0;
    public TextMeshProUGUI bodyCountText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        bodyCountText.text = $"SCORE: {bodyCount}";
    }

    // Update is called once per frame
    void Update()
    {
        bodyCountText.text = $"SCORE: {bodyCount}";
    }
}

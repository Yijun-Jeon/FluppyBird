using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColumnMaker : MonoBehaviour{

    public GameObject Column;

    private float nowTime;
    private float makeTime = 2f;

    public TMP_Text ScoreUI;
    private int score = 0;
    private float scoreTime;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;
        scoreTime = Time.time + 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - nowTime > makeTime)
        {
            nowTime = Time.time;

            GameObject temp = Instantiate(Column);
            temp.transform.parent = gameObject.transform;

            float randomY = Random.Range(-6.15f,-1.5f);

            temp.transform.localPosition = new Vector3(-gameObject.transform.localPosition.x + 5, randomY, 0);
            temp.transform.localScale = new Vector3(1,1,1);
        }

        if(Time.time - scoreTime > 2)
        {
            scoreTime = Time.time;
            score++;
            ScoreUI.text = score.ToString();
        }
    }
}

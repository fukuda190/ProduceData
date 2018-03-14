using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text TimeText;
    float MaxTime = 10;
    float NowTime;
    public float CurrentTime;
    public CanvasGroup canvasGroup;
    public CanvasGroup NextButton;
    public Button NextBtn;
    public Text Over;

    // Use this for initialization
    public void Start()
    {
        canvasGroup.alpha = 0;
        NextButton.alpha = 0;
        NextBtn.interactable = false;
        //StartCoroutine("Timer");
    }

    // Update is called once per frame
    public void Update()
    {
        NowTime += Time.deltaTime;
        CurrentTime = MaxTime - NowTime;   //現在時間の計測（現在時間＝最大時間ー経過時間）

        if (CurrentTime < 0)  //カウントが0になったら計測終了
        {
            canvasGroup.alpha = 1;
            NextButton.alpha = 1;
            NextBtn.interactable = true;
            Over.text = "タイムオーバー";
            CurrentTime = 0;
            ButtonDisplay();
            //GameObject.Find("QuizObject").GetComponent<CSVreader>().QuizLoad();
        }
        TimeText.text = CurrentTime.ToString("F2");

    }
    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(0);
        Update();
    }
    public void ButtonDisplay()
    {
        NextButton.alpha = 1;
        NextBtn.interactable = true;  

    }
}


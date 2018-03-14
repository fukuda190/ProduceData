using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSVreader : MonoBehaviour
{
    public TextAsset CSVfile;
    public List<string[]> csvDatas = new List<string[]>();
    public Text Quiz;
    public Text Select1, Select2, Select3, Select4;
    string Answer;
    public Text IncorrectanswerText;
    public Text CorrectText;
    private AudioSource[] sources;
    public CanvasGroup Select1off, Select2off, Select3off, Select4off;



    // Use this for initialization
    void Start()
    {
        sources = gameObject.GetComponents<AudioSource>();
        Select1off.alpha = 1;
        Select2off.alpha = 1;
        Select3off.alpha = 1;
        Select4off.alpha = 1;
        StartCoroutine("Read");
    }
    void Update()
    {


    }

    // Update is called once per frame
    public void QuizLoad()
    {
        string[] lines = CSVfile.text.Replace("\r\n", "\n").Split("\n"[0]);
        foreach (string line in lines)
        {
            if (line == "") { continue; }
            csvDatas.Add(line.Split(','));
        }
        //ランダムな数をRandomNumに入れて、csvDataから呼び出す
        int RandomNum = Random.Range(0, 32);
        Quiz.text = csvDatas[RandomNum][0];
        Answer = csvDatas[RandomNum][1];
        Select1.text = csvDatas[RandomNum][2];
        Select2.text = csvDatas[RandomNum][3];
        Select3.text = csvDatas[RandomNum][4];
        Select4.text = csvDatas[RandomNum][5];
    }
    IEnumerator Read()
    {
        yield return new WaitForSeconds(0);
        QuizLoad();
    }
    public void Display1()
    {
        if (Answer == Select1.text)
        {
            CorrectText.text = "正解";
            sources[0].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
        else if (Answer != Select1.text)
        {
            IncorrectanswerText.text = "不正解";
            sources[1].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
    }
    public void Display2()
    {
        if (Answer == Select2.text)
        {
            CorrectText.text = "正解";
            sources[0].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
        else if (Answer != Select2.text)
        {
            IncorrectanswerText.text = "不正解";
            sources[1].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
    }
    public void Display3()
    {
        if (Answer == Select3.text)
        {
            CorrectText.text = "正解";
            sources[0].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
        else if (Answer != Select3.text)
        {
            IncorrectanswerText.text = "不正解";
            sources[1].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
    }
    public void Display4()
    {
        if (Answer == Select4.text)
        {
            CorrectText.text = "正解";
            sources[0].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
        else if (Answer != Select4.text)
        {
            IncorrectanswerText.text = "不正解";
            sources[1].Play();
            GameObject.Find("TimeObject").GetComponent<TimeCount>().ButtonDisplay();
        }
    }
    public void DisPlayoff()
    {
        CorrectText.text = "";
        IncorrectanswerText.text = "";
    }
    public void ButtonOff()
    {
        Select1off.alpha = 0;
        Select2off.alpha = 0;
        Select3off.alpha = 0;
        Select4off.alpha = 0;
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public string _Name = "Collect all!";
    public string _Description = "collect 3 green cubes";
    public int _id = 1;
    public bool StartOrNot = true;
    private Text TextOfQuest;
    private Text About;
    private Text Warning_Text;
    public int score = 0; 

    public void OnFinished()
    {
        if (score == 3)
        {
            Warning_Text.text = "YOU WON!";
            TextOfQuest.text = "During Quest: ";
            About.text = "";
            Invoke("SetEmptyWarningText", 3);
        }
        else {
            Warning_Text.text = "Not all cubes are collected!";
            Invoke("SetEmptyWarningText", 3);
        }
    }
    void SetEmptyWarningText() {
        Warning_Text.text = "";
    }

    public void OnStart()
    {
        TextOfQuest.text = "During Quest: " + _Name + " (" + _Description + ")";
        Invoke("FalseSet", 3);
    }
    void FalseSet() {
        StartOrNot = false;
    }

    public void OnUpdate()
    {
        score++;
        About.text = "Score: " + score;
    }


    // Start is called before the first frame update
    void Start()
    {
        TextOfQuest = GameObject.FindGameObjectWithTag("Text_Quest").GetComponent<Text>();
        About = GameObject.FindGameObjectWithTag("AboutQ").GetComponent<Text>();
        Warning_Text = GameObject.FindGameObjectWithTag("Warning").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

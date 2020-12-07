using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 1000;


    public List<Quest> Quests = new List<Quest>();
   // public List<Quest> duringQuest = new List<Quest>();

    private Text TextOfQuest;
    private Text About;
    private Text Warning_Text;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _setText();
        
    }
    private void GetInputAndUpdatePosition()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }

    }

    void Update()
    {
        GetInputAndUpdatePosition();
    }

    void _setText()
    {
        TextOfQuest = GameObject.FindGameObjectWithTag("Text_Quest").GetComponent<Text>();
        About = GameObject.FindGameObjectWithTag("AboutQ").GetComponent<Text>();
        Warning_Text = GameObject.FindGameObjectWithTag("Warning").GetComponent<Text>();
    }

}

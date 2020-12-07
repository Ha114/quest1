using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    GameObject g;
    Quest q;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("QuestGiver")) {
            if (q.StartOrNot == true) {
                q.OnStart();
            }
            if (q.StartOrNot == false)
            {
                q.OnFinished();
            }
        }
        if (gameObject.CompareTag("Collect"))
        {
            if (q.StartOrNot == false)
            {
                q.OnUpdate();
                gameObject.SetActive(false);
            }
        }
    }

    void Start()
    {
        g = GameObject.Find("Player");
        q = g.GetComponent<Quest>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

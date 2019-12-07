using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    bool GoalDestroyFlag = false;

    public GameObject GoalEffect;
    public GameObject GoalText;

    public GameObject NormalText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GoalDestroyFlag = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalDestroyFlag)
        {
            GoalDestroy();
            SetGoalEffect();
            GoalDestroyFlag = true;
        }
    }

    void GoalDestroy()
    {
        Destroy(gameObject, 0.5f);
    }

    void SetGoalEffect()
    {
        NormalText.SetActive(false);
        GoalEffect.SetActive(true);
        GoalText.SetActive(true);
    }
}

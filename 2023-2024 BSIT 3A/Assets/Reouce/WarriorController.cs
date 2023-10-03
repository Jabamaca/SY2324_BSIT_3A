using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorController : MonoBehaviour
{
    [SerializeField]
    private WarriorProperties Stats;

    public bool FollowsScriptableObject = false;
    public float MoveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal"); // Range -1f to +1f

        Vector3 movement = new Vector3(xMovement, 0f, 0f);
        if (FollowsScriptableObject)
        {
            transform.localPosition += movement * (Stats.MovementSpeed * Time.deltaTime);
        }
        else
        {
            transform.localPosition += movement * (MoveSpeed * Time.deltaTime);
        }

        bool oneIsPressed = Input.GetKeyUp("1");

        if (oneIsPressed) Debug.Log("ONE");
    }
}

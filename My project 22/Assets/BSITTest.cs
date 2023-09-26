using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSITTest : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("WE ARE START");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transition = new Vector3 (Time.deltaTime * Speed, 0, 0);
        transform.localPosition += transition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleDataTest2 : MonoBehaviour {

    [SerializeField]
    List<int> IntList = new List<int> ();
    [SerializeField]
    List<DeleDataTest1> IntTest = new List<DeleDataTest1> ();
    [SerializeField]
    Dictionary<string, int> IntDict = new Dictionary<string, int> ();

    [SerializeField]
    private DeleDataTest1 _Button;

    private void Start () {
        int[] intArray = new int[3];

        IntList.Add (4);
        IntList.Add (1);
        IntList.Add (45);
        IntList.Add (-20);

        foreach (int x in IntList) {
            Debug.Log (x.ToString ());
        }

        IntList.Sort ();

        foreach (int x in IntList) {
            Debug.Log (x.ToString ());
        }

        int access = IntList[0];

        IntList[0] = 5;
        IntDict["strength"] = 4;
    }

    private void OnEnable () {
        _Button.OnClick += OnClickParentRespond;
    }

    private void OnDisable () {
        _Button.OnClick -= OnClickParentRespond;
    }

    private void OnClickParentRespond () {
        Debug.Log ("PARENT!!!");
    }

}
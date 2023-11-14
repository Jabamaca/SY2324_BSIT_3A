using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleDataTest1 : MonoBehaviour {

    public delegate void OnClickResponse ();
    public OnClickResponse OnClick = delegate {
    };

    private void OnMouseDown () {
        OnClick?.Invoke ();
    }
}

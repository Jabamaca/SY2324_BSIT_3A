using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleDataTest1 : MonoBehaviour {

    [SerializeField]
    private int Life = 10;
    [SerializeField]
    private SpriteRenderer _Sprite;

    private void OnTriggerEnter2D (Collider2D collision) {
        Life--;

        if (Life <= 0) {
            _Sprite.color = Color.red;
        }
    }

    private void OnTriggerStay2D (Collider2D collision) {
        
    }

    private void OnTriggerExit2D (Collider2D collision) {
        
    }

}

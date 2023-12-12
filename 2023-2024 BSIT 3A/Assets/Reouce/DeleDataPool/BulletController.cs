using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public delegate void OnPoolDelegate (BulletController bullet);
    public OnPoolDelegate OnPool = delegate {
    };

    [SerializeField]
    private Rigidbody2D _RigidBody;

    public float Lifetime = 3f;
    private float _CurrentTime = 0f;

    public float Speed = 4f;

    private void OnCollisionEnter2D (Collision2D collision) {
        PoolObject ();
    }

    private void OnCollisionStay2D (Collision2D collision) {
        
    }

    private void OnCollisionExit2D (Collision2D collision) {
        
    }

    // Update is called once per frame
    void Update () {
        float t = Time.deltaTime;

        _CurrentTime += t;
        _RigidBody.velocity = new Vector2 (Speed, 0f);

        if (_CurrentTime >= Lifetime) {
            PoolObject ();
        }
    }

    public void ResetBullet () {
        gameObject.SetActive (true);
        _CurrentTime = 0f;
    }

    private void PoolObject () {
        gameObject.SetActive (false);
        OnPool?.Invoke (this);
    }
}

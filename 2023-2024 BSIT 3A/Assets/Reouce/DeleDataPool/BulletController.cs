using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public delegate void OnPoolDelegate (BulletController bullet);
    public OnPoolDelegate OnPool = delegate {
    };

    public float Lifetime = 3f;
    private float _CurrentTime = 0f;

    public float Speed = 4f;

    // Update is called once per frame
    void Update () {
        float t = Time.deltaTime;

        _CurrentTime += t;
        transform.position += new Vector3 (Speed * t, 0, 0);

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

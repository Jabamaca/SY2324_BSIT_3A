using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {
    public BulletController BulletToShoot;

    [SerializeField]
    private List<BulletController> _BulletPool = new List<BulletController> ();
    [SerializeField]
    private List<BulletController> _AvailableBullets = new List<BulletController> ();

    private void OnDestroy () {
        foreach (BulletController bullet in _BulletPool) {
            bullet.OnPool -= OnBulletPooled;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown ("1")) {
            BulletController shotBullet = UnpoolBullet ();
            shotBullet.transform.position = transform.position;
            shotBullet.transform.rotation = Quaternion.identity;
        }
    }

    BulletController UnpoolBullet () {
        BulletController bullet;

        // Reuse clause
        if (_AvailableBullets.Count > 0) {
            bullet = _AvailableBullets[0];
            _AvailableBullets.RemoveAt (0);
            bullet.ResetBullet ();
            return bullet;
        }

        // Create clause
        bullet = Instantiate<BulletController> (BulletToShoot);
        bullet.OnPool += OnBulletPooled;
        bullet.ResetBullet ();
        _BulletPool.Add (bullet);

        return bullet;
    }

    void OnBulletPooled (BulletController bullet) {
        _AvailableBullets.Add (bullet);
    }
}
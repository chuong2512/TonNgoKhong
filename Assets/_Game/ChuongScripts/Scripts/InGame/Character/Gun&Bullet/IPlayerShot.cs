using UnityEngine;

public interface IPlayerShot
{
    void Shot();
    void SetTarget(Transform target);
    void Init();
    void SetBarrel(Transform gunBarrel);
    void SetBullet(GameObject bullet);
    void StopShot();
    bool IsShoting();
}
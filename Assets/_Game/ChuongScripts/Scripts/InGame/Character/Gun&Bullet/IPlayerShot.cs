using Game;
using UnityEngine;

public interface IPlayerShot
{
    void Shot();
    void SetBulletAttribute(BulletAttribute attribute);
    void SetTarget(Transform target);
    void Init();
    void SetBullet(GameObject bullet);
    void StopShot();
    bool IsShoting();
}
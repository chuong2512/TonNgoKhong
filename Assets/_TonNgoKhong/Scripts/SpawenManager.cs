using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawenManager : MonoBehaviour
{
    GameObject[] Enemys;
    public int EnemysLength;

    [FormerlySerializedAs("UI")] [Header("Spawener Managers")] [Header("Enemys Manager")]
    public GameObject Zombie;

    public GameObject[] ZombieLevel;

    [Header("Spawents Poins")] public GameObject SpawenLocalisation;
    public GameObject Spawen1;
    public GameObject Spawen2;
    public GameObject Spawen3;
    public GameObject Spawen4;

    [Header("Boolean Manager")] internal bool SpawenPos1 = false;
    internal bool SpawenPos2 = false;
    internal bool SpawenPos3 = false;
    internal bool SpawenPos4 = false;
    internal bool ManagerPose = false;
    internal bool MakeIt = false;
    [Header("Vectors Controller")] internal Vector3 Pos;

    void OnEnable()
    {
        StartCoroutine(SpaweningManager());
        StartCoroutine(stopSpawning());
    }

    void Update()
    {
        MakeIt = true;
    }

    public IEnumerator stopSpawning()
    {
        yield return new WaitForEndOfFrame();
        if (MakeIt == true)
        {
            yield return new WaitForSeconds(1f);
            ManagerPose = true;
            yield return new WaitForSeconds(10f);
            ManagerPose = false;
            StartCoroutine(SpaweningManager());
        }

        StartCoroutine(stopSpawning());
    }

    public IEnumerator SpaweningManager()
    {
        Debug.Log("SpaweningManager");
        yield return new WaitForEndOfFrame();
        if (ManagerPose == false)
        {
            if (MakeIt == true)
            {
                Enemys = GameObject.FindGameObjectsWithTag("Enemy");
                EnemysLength = Enemys.Length;
                if (EnemysLength < 100)
                {
                    (Instantiate(Zombie,
                            new Vector3(Spawen1.transform.position.x,
                                Spawen1.transform.position.y + Random.Range(-5, 5),
                                Spawen1.transform.position.z), Spawen1.transform.rotation) as GameObject).transform
                        .SetParent(SpawenLocalisation.transform);
                    if (GameManager.Instance?.CurrentReload == 0)
                    {
                        (Instantiate(ZombieLevel[0],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                    else if (GameManager.Instance?.CurrentReload == 1)
                    {
                        (Instantiate(ZombieLevel[1],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                    else if (GameManager.Instance?.CurrentReload == 2)
                    {
                        (Instantiate(ZombieLevel[2],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                    else if (GameManager.Instance?.CurrentReload == 3)
                    {
                        (Instantiate(ZombieLevel[3],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                    else if (GameManager.Instance?.CurrentReload == 4)
                    {
                        (Instantiate(ZombieLevel[4],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                    else if (GameManager.Instance?.CurrentReload >= 4)
                    {
                        (Instantiate(ZombieLevel[4],
                                new Vector3(Spawen2.transform.position.x + Random.Range(-5, 5),
                                    Spawen2.transform.position.y, Spawen2.transform.position.z),
                                Spawen2.transform.rotation)
                            as GameObject).transform.SetParent(SpawenLocalisation.transform);
                    }
                }

                yield return new WaitForSeconds(0.9f);
            }

            StartCoroutine(SpaweningManager());
        }
    }
}
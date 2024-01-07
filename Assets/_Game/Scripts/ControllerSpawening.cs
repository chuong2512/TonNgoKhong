using SinhTon;

public class ControllerSpawening : Singleton<ControllerSpawening>
{
    public SpawenManager SpawenOne;
    public SpawenManager SpawenTwo;

    void Update()
    {
        StartCoroutine(SpawenOne.SpaweningManager());
        StartCoroutine(SpawenTwo.SpaweningManager());
        StartCoroutine(SpawenOne.stopSpawning());
        StartCoroutine(SpawenTwo.stopSpawning());
    }
}
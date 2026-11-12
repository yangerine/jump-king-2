using UnityEngine;

public class Timer : MonoBehaviour
{
    private float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);
    }
}

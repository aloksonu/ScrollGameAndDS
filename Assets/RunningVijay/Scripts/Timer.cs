using UnityEngine;
using System.Collections;
using TMPro;

public class Timer : MonoBehaviour
{
    int time;
    public TextMeshProUGUI tmpTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 0;
        Debug.Log(PlayerController.Instance.value);
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (!PlayerController.Instance.isGameOver)
        {
            time++;
            tmpTimer.text = time.ToString();
            yield return new WaitForSeconds(1f);   // wait for 1 seconds}

        }
    }
}

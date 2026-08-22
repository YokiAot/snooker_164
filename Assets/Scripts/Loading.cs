using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private float waitiSecond = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        if (waitiSecond > 0f)
        {
            waitiSecond -= Time.deltaTime;
        }
        else
        {
            StartCoroutine(LoadNewScene());
        }
    }

    private IEnumerator LoadNewScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync("Scene01");
        //LoadScene() ซีนปัจจุบันหยุดทำงานแล่นซีนใหม่อาจจะกระตุกเล็กน้อยเพราะสลับซีน LoadSceneAsync โหลดซีนโดยที่อีกซีนยังทำงานอยู่

        while (!oper.isDone)
        {
            slider.value = oper.progress / 0.9f;
            yield return null;
        }
    }
}

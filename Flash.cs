using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Flash : MonoBehaviour
{
    private Image WhiteImage;
    private AudioSource WhiteNoise;
    private AudioSource Bang;

    // Start is called before the first frame update
    void Start()
    {
        WhiteImage = GameObject.FindGameObjectWithTag("WhiteImage").GetComponent<Image>();
        WhiteNoise = GameObject.FindGameObjectWithTag("WhiteNoise").GetComponent<AudioSource>();
        Bang = GameObject.FindGameObjectWithTag("Bang").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            StartCoroutine(WhiteFade());
        }
    }

    IEnumerator WhiteFade()
    {
        yield return new WaitForSeconds(0.016f);

        WhiteImage.color = new Vector4(1, 1, 1, 1);
        Bang.Play();
        WhiteNoise.Play();
        Debug.Log("Yippie?");


        float FadeSpeed = 0.8f;
        float Modifier = 0.01f;
        float WaitTime = 0;

        for (int i = 0; WhiteImage.color.a > 0; i++)
        {
            WhiteImage.color = new Vector4(1, 1, 1, FadeSpeed);
            FadeSpeed = FadeSpeed - 0.025f;
            Modifier = Modifier * 100f;
            WaitTime = 0.016f - Modifier;
            if (WaitTime < 0.1f) WaitTime = 0.016f;
            WhiteNoise.volume -= -0.025f;
            yield return new WaitForSeconds(WaitTime);
        }

        WhiteNoise.Stop();
        WhiteNoise.volume = 1;

    }
}


using UdonSharp;
using UnityEngine;

public class WeatherCycle : UdonSharpBehaviour
{
    public WeatherController weather;
    public float cycleTime = 1800f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > cycleTime)
        {
            timer = 0;
            weather.currentWeather =
                (WeatherController.Weather)Random.Range(0,4);
        }
    }
}

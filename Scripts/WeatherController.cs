
using UdonSharp;
using UnityEngine;

public class WeatherController : UdonSharpBehaviour
{
    public enum Weather { Clear, Rain, AshRain, AbyssFog }
    public Weather currentWeather;
}

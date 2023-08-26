using System;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameObject navyismClock;

    private float _elapsedTime = 0f;
    public float elapsedTime => _elapsedTime;

    private bool _paused = false;

    void Update()
    {
        if (!_paused)
        {
            _elapsedTime += Time.deltaTime;
            var time = TimeSpan.FromSeconds(_elapsedTime);
            navyismClock.GetComponent<TextMeshProUGUI>().text = time.ToString("mm':'ss'.'ff");
        }
    }

    public void PauseTime()
    {
        _paused = true;
    }

    public void PlayTime()
    {
        _paused = false;
    }

    public void Restart()
    {
        _elapsedTime = 0f;
        PlayTime();
    }
}

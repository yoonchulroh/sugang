using System;
using UnityEngine;
using TMPro;

public class ApplyManager : MonoBehaviour
{
    [SerializeField] private GameObject _scoreText;

    private float elapsedTime => GameManager.Instance.timeManager.elapsedTime;

    public void Applied()
    {
        if (elapsedTime > 10f)
        {
            SetScore(elapsedTime - 10f);
        } else {
            SetScore(0);
        }
        GameManager.Instance.timeManager.PauseTime();
    }

    private void SetScore(float score)
    {
        _scoreText.GetComponent<TextMeshProUGUI>().text = Convert.ToString(score);
    }
}

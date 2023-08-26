using System;
using UnityEngine;
using TMPro;

public class ApplyManager : MonoBehaviour
{
    [SerializeField] private GameObject _alertBoxPrefab;
    private GameObject _alertBox;
    private GameObject _scoreText;

    private float elapsedTime => GameManager.Instance.timeManager.elapsedTime;

    public void Applied()
    {
        _alertBox = Instantiate<GameObject>(_alertBoxPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        _scoreText = GameObject.FindGameObjectWithTag("AlertText");
        if (elapsedTime > 10f && GameManager.Instance.securityManager.CheckInputCode())
        {
            SetScore(elapsedTime - 10f);
        } else {
            SetScore(0);
        }
        GameManager.Instance.timeManager.PauseTime();
    }

    private void SetScore(float score)
    {
        _scoreText.GetComponent<TextMeshPro>().text = Convert.ToString(score);
    }
}

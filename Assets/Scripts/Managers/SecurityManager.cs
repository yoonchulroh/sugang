using System;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class SecurityManager : MonoBehaviour
{
    [SerializeField] private GameObject _securityCodeField;
    [SerializeField] private GameObject _inputCodeField;

    private int _securityCode;
    private string _securityCodeToString;
    private int _inputCode;
    private string _inputCodeToString;

    void Start()
    {
        Restart();
    }

    void Update()
    {
        CaptureKeyboardInput();
    }

    public void Restart()
    {
        UpdateSecurityCode();
        _inputCode = 0;
        _inputCodeToString = "";
        _inputCodeField.GetComponent<TextMeshProUGUI>().text = _inputCodeToString;
    }

    public bool CheckInputCode()
    {
        if (_securityCodeToString == _inputCodeToString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void UpdateSecurityCode()
    {
        _securityCode = Random.Range(0, 99);
        _securityCodeToString = Convert.ToString(_securityCode);
        if (_securityCode < 10)
        {
            _securityCodeToString = "0" + _securityCodeToString;
        }
        _securityCodeField.GetComponent<TextMeshProUGUI>().text = _securityCodeToString;
    }

    private void UpdateInputCode(int input)
    {
        if (input == -1)
        {
            if (_inputCodeToString.Length == 1)
            {
                _inputCode = 0;
                _inputCodeToString = "";
            }
            else if (_inputCodeToString.Length == 2)
            {
                _inputCode = _inputCode / 10;
                _inputCodeToString = Convert.ToString(_inputCode);
            }
        }
        else
        {
            if (_inputCodeToString.Length == 0)
            {
                _inputCode = input;
                _inputCodeToString = Convert.ToString(_inputCode);
            } else if (_inputCodeToString.Length == 1)
            {
                _inputCode = 10 * _inputCode + input;
                _inputCodeToString = Convert.ToString(_inputCode);
                if (_inputCodeToString.Length == 1)
                {
                    _inputCodeToString = "0" + _inputCodeToString;
                }
            }
        }

        _inputCodeField.GetComponent<TextMeshProUGUI>().text = _inputCodeToString;
    }

    private void CaptureKeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UpdateInputCode(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UpdateInputCode(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UpdateInputCode(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UpdateInputCode(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            UpdateInputCode(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            UpdateInputCode(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            UpdateInputCode(7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            UpdateInputCode(8);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            UpdateInputCode(9);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            UpdateInputCode(0);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            UpdateInputCode(-1);
        }
    }
}

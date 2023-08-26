using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButtonBehaviour : MonoBehaviour
{
    [SerializeField] private Sprite _notSelectedImage;
    [SerializeField] private Sprite _selectedImage;

    private bool _selected = false;

    void Update()
    {
        if (_selected)
        {
            GetComponent<SpriteRenderer>().sprite = _selectedImage;
        }
        else
        {
        GetComponent<SpriteRenderer>().sprite = _notSelectedImage;
        }
    }

    void OnMouseDown()
    {
        _selected = !_selected;
    }
}

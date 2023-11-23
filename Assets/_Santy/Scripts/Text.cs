using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    [SerializeField] int id;
    public TextManager TextManager;
    private void OnEnable()
    {
        StartCoroutine(TestCoroutine());
    }

    private IEnumerator TestCoroutine()
    {
        yield return new WaitForSeconds(1f);
        transform.GetComponent<TextMeshProUGUI>().text = TextManager.setText(id);
    }
    
}

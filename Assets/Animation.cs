using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private float angulo = 0;
    public float velocidadeRotacao = 0.1F;
    public float amplitude = 0.001f;
    public float velocidadeDeslocamento = 0.5f;
    public float rotate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotate, Space.Self);
        transform.Translate(0, 0, amplitude*Mathf.Sin(angulo*velocidadeDeslocamento));
        angulo += velocidadeRotacao;
    }
}

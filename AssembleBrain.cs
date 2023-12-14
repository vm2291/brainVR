using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleBrain : MonoBehaviour
{

    public Transform[] brainParts;
    private Vector3[] capturedPositions;
    private Quaternion[] capturedRotation;

    // Start is called before the first frame update
    void Start()
    {
        capturedPositions = new Vector3[brainParts.Length];
        capturedRotation = new Quaternion[brainParts.Length];

        for(int i = 0; i < brainParts.Length; i++)
        {
            capturedPositions[i] = brainParts[i].transform.position;
            capturedRotation[i] = brainParts[i].rotation;

        }
        
    }

    public void Assemble()
    {
        for (int i = 0; i < brainParts.Length; i++)
        {
            brainParts[i].transform.position = capturedPositions[i];
            brainParts[i].rotation = capturedRotation[i];

        }
    }

}

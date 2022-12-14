using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffset : MonoBehaviour
{
    [SerializeField] InitialBoardSystem _initialBoard;
    private Camera cam;
    private void Awake()
    {
        cam = GetComponent<Camera>();
    }
    // Start is called before the first frame update
    void Start()
    {
        int width = _initialBoard.Width;
        int height = _initialBoard.Height;
        CheckOffSetCamera(width,height);
    }
    private void CheckOffSetCamera(int width, int height)
    {
        float offSetScale = 3.8f;
        transform.position = new Vector3(width / 2, height / 2, -10);
        cam.orthographicSize = (width + height) / offSetScale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2d : MonoBehaviour
{
    private HormigaScript hormigaScript;

    RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    HormigaScript focus;
    bool isDrag;

    public List<GameObject> rooms = new List<GameObject>(); // Lista de habitaciones
    public List<Transform> movableObjects = new List<Transform>(); // Lista de objetos que se pueden mover

    void Start()
    {
        hormigaScript = FindObjectOfType<HormigaScript>();

        isDrag = false;
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && hormigaScript.movimientoRealizado)
        {
            hit = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));

            if (hit.collider != null)
            {
                focus = hit.transform.GetComponent<HormigaScript>();
                if (focus != null)
                {
                    isDrag = true;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0) && isDrag)
        {
            isDrag = false;
        }

        if (isDrag && movableObjects.Contains(focus.transform))
        {
            mousePos = Input.mousePosition;
            mousePos.z = -cam.transform.position.z;
            pos = cam.ScreenToWorldPoint(mousePos);

            focus.transform.position = new Vector3(pos.x, pos.y, focus.transform.position.z);
        }
    }
}

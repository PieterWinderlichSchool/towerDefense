using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour {

    private float rayLength = 1000f;
    public LayerMask layerMask;

    public Material mat1;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {

                if (hit.collider.tag == "Land")
                {
                    hit.collider.gameObject.GetComponent<Land>().PlaceTower();
                }

            }

        }
	}
}

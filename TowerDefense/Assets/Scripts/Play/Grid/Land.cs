using UnityEngine;

public class Land : MonoBehaviour
{

    Renderer rend;

    public Material occupied;
    public Material land;

    private TowerLimitor tl;

    public GameObject towerPrefab;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        tl = GameObject.Find("Placeholder").GetComponent<TowerLimitor>();

        //rend.material.shader = Shader.Find("_Color");
        rend.material = land;

        //Spec();
    }

    public void PlaceTower()
    {

        //rend.material.shader = Shader.Find("_Color");
        rend.material = occupied;

        GameObject placedTower = Instantiate(towerPrefab, transform.position, Quaternion.identity);
        placedTower.transform.parent = transform;
        tl.AddTower(placedTower);

        //Spec();
    }

    public void RemoveTower()
    {
        //rend.material.shader = Shader.Find("_Color");
        rend.material = land;
        //Spec();
    }

    void Spec()
    {
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
    }

}

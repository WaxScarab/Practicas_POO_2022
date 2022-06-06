using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbaro : MonoBehaviour
{

    public Enemy barbaro = new Enemy(100, "barbaro", 10);
    public Enemy mago = new Enemy(30, "Mago", 50);

    public List<Enemy> enemyList;
    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(new Enemy(100, "barbaro", 10));
        enemyList.Add(new Enemy(30, "Mago", 50));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

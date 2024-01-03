using UnityEngine;
using System.Collections;

public class RandomMaterial : MonoBehaviour {

    public int x = 0;
    public static float level { get; set; } = 1;
    private float levelOne = 1f;
    private float levelTwo = 1.5f;
    private float levelThree = 1.9f;
    private float levelFour = 2.1f;
    private float levelFive = 3.2f;

    private int[] levels = new int[10] { 0, 2, 2, 5, 5, 8, 8, 10, 10, 12 };
    // Use this for initialization
    void Awake () {
        //GetComponent<Renderer>().material = GetRandomMaterial();
        GetComponent<Renderer>().material = LevelMaterial();
        if (x < levels[9])
        {
            x++;
        }
        else
        {
            x = 0;
        }

    }


    /// <summary>
    /// helper method to get a random color
    /// </summary>
    /// <returns></returns>
    public Material GetRandomMaterial()
    {
        int x = Random.Range(0, 5);
        if (x == 0)
            return Resources.Load("Materials/redMaterial") as Material;
        else if (x == 1)
            return Resources.Load("Materials/greenMaterial") as Material;
        else if (x == 2)
            return Resources.Load("Materials/blueMaterial") as Material;
        else if (x == 3)
            return Resources.Load("Materials/yellowMaterial") as Material;
        else if (x == 4)
            return Resources.Load("Materials/purpleMaterial") as Material;
        else
            return Resources.Load("Materials/redMaterial") as Material;
    }

    public Material LevelMaterial()
    {
        /*        return Resources.Load("Materials/whiteMaterial") as Material;*/

        if (x >= levels[0] && x < levels[1])
        {
            if (level != levelFive) level = levelOne;
            return Resources.Load("Materials/levelOne") as Material;
        }
        else if (x >= levels[2] && x < levels[3])
        {
            if (level != levelFive) level = levelTwo;
            return Resources.Load("Materials/levelTwo") as Material;
        }
        else if (x >= levels[4] && x < levels[5])
        {
            if (level != levelFive) level = levelThree;
            return Resources.Load("Materials/levelThree") as Material;
        }
        else if (x >= levels[6] && x < levels[7])
        {
            if (level != levelFive) level = levelFour;
            return Resources.Load("Materials/levelFour") as Material;
        }
        else if (x >= levels[8] && x < levels[9])
        {
            if (level != levelFive) level = levelFive;
            return Resources.Load("Materials/levelFive") as Material;
        }
        else
            return Resources.Load("Materials/levelFive") as Material;

    }

}

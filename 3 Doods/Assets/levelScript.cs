using System.IO;
using UnityEngine;

public class levelScript : MonoBehaviour
{
    private StreamReader streamReader;
    private string reader;
    private Animator anim;
    [SerializeField] private GameObject lvl2, lvl3;
    public void Start()
    {
        anim = GetComponent<Animator>();
        streamReader = File.OpenText("CompletedLevels.txt");
        while (!streamReader.EndOfStream)
        {
            reader = streamReader.ReadLine();
            switch (reader)
            {
                case "lvl1G":
                    anim.SetBool("lvl1G",true);
                    break;
                case "lvl2":
                    anim.SetBool("lvl2", true);
                    lvl2.SetActive(true);
                    break;
                case "lvl2G":
                    anim.SetBool("lvl2G", true); 
                    break;
                case "lvl3":
                    anim.SetBool("lvl3", true);
                    lvl3.SetActive(true);
                    break;
                case "lvl3G":
                    anim.SetBool("lvl3G", true);
                    break;
            }

        }
    }
}

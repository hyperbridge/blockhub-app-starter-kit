using UnityEngine;
using System.Collections;

using UMod.Interface;

public class Sphere : ModScript
{
    private GameObject sphere = null;
    private float scale = 0f;

    public override void OnModLoaded()
    {
        // Spawn the sphere
        sphere = ModAssets.Instantiate<GameObject>("Sphere");
        sphere.transform.localScale = new Vector3(scale, scale, scale);
    }

    public override void OnModUpdate()
    {
        if (sphere != null)
        {
            // We need to constantly scale up the sphere until it is back to its normal size
            if (scale < 1)
            {
                // Set the scale of the sphere
                sphere.transform.localScale = new Vector3(scale, scale, scale);

                // Increase the scale for the next update
                scale += Time.deltaTime;
            }
        }
    }
}

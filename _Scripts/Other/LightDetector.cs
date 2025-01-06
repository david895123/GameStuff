using UnityEngine;

public class LightDetector : MonoBehaviour
{
    [SerializeField] RenderTexture lightRenderTexture; // Assign in Inspector
    [SerializeField] Camera lightCamera; // Assign in Inspector
    [SerializeField] Shadow shadow;
    private void Start()
    {
        RenderTexture.active = lightRenderTexture;

    }
    void Update()
    {
        Vector3 worldPosition = transform.position;
        Vector3 viewportPosition = lightCamera.WorldToViewportPoint(worldPosition);

        if (viewportPosition.x >= 0 && viewportPosition.x <= 1 &&
            viewportPosition.y >= 0 && viewportPosition.y <= 1)
        {
            // Convert viewport position to texture UV coordinates
            int x = Mathf.FloorToInt(viewportPosition.x * lightRenderTexture.width);
            int y = Mathf.FloorToInt(viewportPosition.y * lightRenderTexture.height);

            // Read pixel color from the RenderTexture
            RenderTexture.active = lightRenderTexture;
            Texture2D texture = new Texture2D(1, 1, TextureFormat.RGB24, false);
            texture.ReadPixels(new Rect(x, y, 1, 1), 0, 0);
            texture.Apply();
            RenderTexture.active = null;

            // Get the light level from the pixel color
            Color pixelColor = texture.GetPixel(0, 0);
            float lightLevel = pixelColor.grayscale;
            shadow.LightChange(lightLevel * 100);

            Destroy(texture); // Cleanup temporary texture
        }
    }
}
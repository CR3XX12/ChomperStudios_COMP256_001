Shader "Custom/BlackWithBlood"
{
    Properties
    {
        _MainColor ("Base Color", Color) = (0,0,0,1)
        _BloodTex ("Blood Texture", 2D) = "white" {}
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _BloodTex;
        fixed4 _MainColor;

        struct Input
        {
            float2 uv_BloodTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Base black
            o.Albedo = _MainColor.rgb;

            // Sample blood texture
            fixed4 blood = tex2D(_BloodTex, IN.uv_BloodTex);

            // Blend red blood where alpha > 0
            o.Albedo = lerp(o.Albedo, blood.rgb, blood.a);
        }
        ENDCG
    }

    FallBack "Diffuse"
}

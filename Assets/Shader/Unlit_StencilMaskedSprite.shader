Shader "Unlit/StencilMaskedSprite" {
	Properties {
		[UnityPerMaterial] _MainTex ("Texture", 2D) = "white" {}
		[UnityPerMaterial] _StencilRef ("StencilRef", Float) = 0
		[UnityPerMaterial] _StencilReadMask ("StencilReadMask", Float) = 0
		[UnityPerMaterial] _Color ("Tint", Vector) = (1,1,1,1)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}
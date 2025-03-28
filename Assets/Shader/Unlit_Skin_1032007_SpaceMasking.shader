Shader "Unlit/Skin_1032007_SpaceMasking" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_SpaceTex ("Space Texture", 2D) = "white" {}
		_StarTex ("Star Texture", 2D) = "white" {}
		_WaveTex ("Wave Texture", 2D) = "white" {}
		[UnityPerMaterial] _SpaceMoveSpeed ("Space Move Speed", Float) = 0
		[UnityPerMaterial] _WaveMultiplier ("Wave Multiplier", Float) = 0.01
		[UnityPerMaterial] _WaveAlphaPow ("Wave Alpha Pow", Float) = 2
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}
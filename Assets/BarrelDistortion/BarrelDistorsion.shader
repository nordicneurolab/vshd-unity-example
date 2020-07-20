// https://github.com/wolf96/shader_for_unity/blob/master/Post%20processing/Distortion/Barrel/Barrel.shader as reference

Shader "Hidden/BarrelDistorsion" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "" {}
			kcube("kcube", range(0, 3)) = 0.4
			k("k", range(-3, 3)) = -0.7
	}
	

	
	// Shader code pasted into all further CGPROGRAM blocks
	CGINCLUDE
	
	#include "UnityCG.cginc"
	
	struct v2f {
		float4 pos : POSITION;
		float2 uv : TEXCOORD0;
	};
	
	sampler2D _MainTex;
	
	float2 intensity;
	
	float k; 
	float kcube;
	
	
	v2f vert( appdata_img v ) 
	{
		v2f o;
		o.pos = UnityObjectToClipPos(v.vertex);
		o.uv = v.texcoord.xy;
		return o;
	} 
	
	half4 frag(v2f i) : COLOR 
	{
	
 		half2  coords = i.uv; 
		
		
		float r2 = (coords.x-0.5) * (coords.x-0.5) + (coords.y-0.5) * (coords.y-0.5); // Nuevo

        float f = 0; 
		
		f = 1+ r2 * (k + kcube * sqrt(r2));
		  
		half2 realCoordOffs;
		realCoordOffs.x = f*(coords.x-0.5)+0.5; 
		realCoordOffs.y = f*(coords.y-0.5)+0.5;
		
		half4 color;
		half4 black = (0,0,0,0);
		
		if (realCoordOffs.x >= 0.0 && realCoordOffs.x <= 1.0 && realCoordOffs.y >= 0.0 && realCoordOffs.y <= 1.0) { 
			color = tex2D (_MainTex, realCoordOffs);	 
		} else {
			color = black;	 
		}
		
		return color;
	}

 
	ENDCG 


Subshader {
 Pass {
	  ZTest Always Cull Off ZWrite Off
	  Fog { Mode off }      

      CGPROGRAM
      #pragma fragmentoption ARB_precision_hint_fastest 
      #pragma vertex vert
      #pragma fragment frag
      ENDCG
  }
  
}

Fallback off
	
} // shader
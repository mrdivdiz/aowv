Shader "Spine/SkeletonHueInvert" {
Properties {
 _Cutoff ("Shadow alpha cutoff", Range(0,1)) = 0.1
 _MainTex ("Texture to blend", 2D) = "black" { }
}
SubShader { 
 LOD 100
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Cull Off
  Blend One OneMinusSrcAlpha
  ColorMaterial AmbientAndDiffuse
  SetTexture [_MainTex] { combine texture * primary }
 }
 Pass {
  Name "CASTER"
  Tags { "LIGHTMODE"="SHADOWCASTER" "SHADOWSUPPORT"="true" "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  Cull Off
  Fog { Mode Off }
  Blend One OneMinusSrcAlpha
  Offset 1, 1
  GpuProgramID 23874
Program "vp" {
SubProgram "gles " {
Keywords { "SHADOWS_DEPTH" }
"!!GLES


#ifdef VERTEX

attribute vec4 _glesVertex;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 unity_LightShadowBias;
uniform highp mat4 glstate_matrix_mvp;
uniform highp vec4 _MainTex_ST;
varying highp vec2 xlv_TEXCOORD1;
void main ()
{
  highp vec4 tmpvar_1;
  tmpvar_1.w = 1.0;
  tmpvar_1.xyz = _glesVertex.xyz;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * tmpvar_1);
  highp vec4 clipPos_3;
  clipPos_3.xyw = tmpvar_2.xyw;
  clipPos_3.z = (tmpvar_2.z + clamp ((unity_LightShadowBias.x / tmpvar_2.w), 0.0, 1.0));
  clipPos_3.z = mix (clipPos_3.z, max (clipPos_3.z, -(tmpvar_2.w)), unity_LightShadowBias.y);
  gl_Position = clipPos_3;
  xlv_TEXCOORD1 = ((_glesMultiTexCoord0.xy * _MainTex_ST.xy) + _MainTex_ST.zw);
}



#endif
#ifdef FRAGMENT

uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying highp vec2 xlv_TEXCOORD1;
void main ()
{
  mediump float s_1;
  mediump float h_2;
  mediump float b_3;
  mediump float g_4;
  mediump float r_5;
  lowp vec4 texcol_6;
  lowp vec4 tmpvar_7;
  tmpvar_7 = texture2D (_MainTex, xlv_TEXCOORD1);
  texcol_6 = tmpvar_7;
  lowp float tmpvar_8;
  tmpvar_8 = tmpvar_7.x;
  r_5 = tmpvar_8;
  lowp float tmpvar_9;
  tmpvar_9 = tmpvar_7.y;
  g_4 = tmpvar_9;
  lowp float tmpvar_10;
  tmpvar_10 = tmpvar_7.z;
  b_3 = tmpvar_10;
  mediump float tmpvar_11;
  tmpvar_11 = max (r_5, max (g_4, b_3));
  mediump float tmpvar_12;
  tmpvar_12 = min (r_5, min (g_4, b_3));
  mediump float tmpvar_13;
  tmpvar_13 = (tmpvar_11 - tmpvar_12);
  h_2 = 0.0;
  if ((tmpvar_11 == r_5)) {
    mediump float tmpvar_14;
    tmpvar_14 = (((g_4 - b_3) / tmpvar_13) / 6.0);
    mediump float tmpvar_15;
    tmpvar_15 = (fract(abs(tmpvar_14)) * 6.0);
    mediump float tmpvar_16;
    if ((tmpvar_14 >= 0.0)) {
      tmpvar_16 = tmpvar_15;
    } else {
      tmpvar_16 = -(tmpvar_15);
    };
    h_2 = (1.046667 * tmpvar_16);
  } else {
    if ((tmpvar_11 == g_4)) {
      h_2 = (1.046667 * ((
        (b_3 - r_5)
       / tmpvar_13) + 2.0));
    } else {
      h_2 = (1.046667 * ((
        (r_5 - g_4)
       / tmpvar_13) + 4.0));
    };
  };
  s_1 = 0.0;
  mediump float tmpvar_17;
  tmpvar_17 = ((tmpvar_11 + tmpvar_12) / 2.0);
  if ((tmpvar_13 != 0.0)) {
    s_1 = (tmpvar_13 / (1.0 - abs(
      ((2.0 * tmpvar_17) - 1.0)
    )));
  };
  mediump float tmpvar_18;
  tmpvar_18 = (h_2 - 3.14);
  h_2 = tmpvar_18;
  if ((tmpvar_18 < 0.0)) {
    h_2 = (tmpvar_18 + 6.28);
  };
  mediump float tmpvar_19;
  tmpvar_19 = ((1.0 - abs(
    ((2.0 * tmpvar_17) - 1.0)
  )) * s_1);
  mediump float tmpvar_20;
  tmpvar_20 = ((h_2 / 1.046667) / 2.0);
  mediump float tmpvar_21;
  tmpvar_21 = (fract(abs(tmpvar_20)) * 2.0);
  mediump float tmpvar_22;
  if ((tmpvar_20 >= 0.0)) {
    tmpvar_22 = tmpvar_21;
  } else {
    tmpvar_22 = -(tmpvar_21);
  };
  mediump float tmpvar_23;
  tmpvar_23 = (tmpvar_19 * (1.0 - abs(
    (tmpvar_22 - 1.0)
  )));
  mediump float tmpvar_24;
  tmpvar_24 = (tmpvar_17 - (tmpvar_19 / 2.0));
  mediump float tmpvar_25;
  tmpvar_25 = ((h_2 * 180.0) / 3.14);
  h_2 = tmpvar_25;
  if ((tmpvar_25 < 60.0)) {
    r_5 = tmpvar_19;
    g_4 = tmpvar_23;
    b_3 = 0.0;
  } else {
    if ((tmpvar_25 < 120.0)) {
      r_5 = tmpvar_23;
      g_4 = tmpvar_19;
      b_3 = 0.0;
    } else {
      if ((tmpvar_25 < 180.0)) {
        r_5 = 0.0;
        g_4 = tmpvar_19;
        b_3 = tmpvar_23;
      } else {
        if ((tmpvar_25 < 240.0)) {
          r_5 = 0.0;
          g_4 = tmpvar_23;
          b_3 = tmpvar_19;
        } else {
          if ((tmpvar_25 < 300.0)) {
            r_5 = tmpvar_23;
            g_4 = 0.0;
            b_3 = tmpvar_19;
          } else {
            r_5 = tmpvar_19;
            g_4 = 0.0;
            b_3 = tmpvar_23;
          };
        };
      };
    };
  };
  mediump float tmpvar_26;
  tmpvar_26 = (r_5 + tmpvar_24);
  r_5 = tmpvar_26;
  mediump float tmpvar_27;
  tmpvar_27 = (g_4 + tmpvar_24);
  g_4 = tmpvar_27;
  mediump float tmpvar_28;
  tmpvar_28 = (b_3 + tmpvar_24);
  b_3 = tmpvar_28;
  mediump vec4 tmpvar_29;
  tmpvar_29.x = tmpvar_26;
  tmpvar_29.y = tmpvar_27;
  tmpvar_29.z = tmpvar_28;
  tmpvar_29.w = tmpvar_7.w;
  texcol_6.yzw = tmpvar_29.yzw;
  texcol_6.x = 0.0;
  lowp float x_30;
  x_30 = (texcol_6.w - _Cutoff);
  if ((x_30 < 0.0)) {
    discard;
  };
  gl_FragData[0] = vec4(0.0, 0.0, 0.0, 0.0);
}



#endif"
}
SubProgram "gles " {
Keywords { "SHADOWS_CUBE" }
"!!GLES


#ifdef VERTEX

attribute vec4 _glesVertex;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _LightPositionRange;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 _Object2World;
uniform highp vec4 _MainTex_ST;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec2 xlv_TEXCOORD1;
void main ()
{
  xlv_TEXCOORD0 = ((_Object2World * _glesVertex).xyz - _LightPositionRange.xyz);
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD1 = ((_glesMultiTexCoord0.xy * _MainTex_ST.xy) + _MainTex_ST.zw);
}



#endif
#ifdef FRAGMENT

uniform highp vec4 _LightPositionRange;
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec2 xlv_TEXCOORD1;
void main ()
{
  mediump float s_1;
  mediump float h_2;
  mediump float b_3;
  mediump float g_4;
  mediump float r_5;
  lowp vec4 texcol_6;
  lowp vec4 tmpvar_7;
  tmpvar_7 = texture2D (_MainTex, xlv_TEXCOORD1);
  texcol_6 = tmpvar_7;
  lowp float tmpvar_8;
  tmpvar_8 = tmpvar_7.x;
  r_5 = tmpvar_8;
  lowp float tmpvar_9;
  tmpvar_9 = tmpvar_7.y;
  g_4 = tmpvar_9;
  lowp float tmpvar_10;
  tmpvar_10 = tmpvar_7.z;
  b_3 = tmpvar_10;
  mediump float tmpvar_11;
  tmpvar_11 = max (r_5, max (g_4, b_3));
  mediump float tmpvar_12;
  tmpvar_12 = min (r_5, min (g_4, b_3));
  mediump float tmpvar_13;
  tmpvar_13 = (tmpvar_11 - tmpvar_12);
  h_2 = 0.0;
  if ((tmpvar_11 == r_5)) {
    mediump float tmpvar_14;
    tmpvar_14 = (((g_4 - b_3) / tmpvar_13) / 6.0);
    mediump float tmpvar_15;
    tmpvar_15 = (fract(abs(tmpvar_14)) * 6.0);
    mediump float tmpvar_16;
    if ((tmpvar_14 >= 0.0)) {
      tmpvar_16 = tmpvar_15;
    } else {
      tmpvar_16 = -(tmpvar_15);
    };
    h_2 = (1.046667 * tmpvar_16);
  } else {
    if ((tmpvar_11 == g_4)) {
      h_2 = (1.046667 * ((
        (b_3 - r_5)
       / tmpvar_13) + 2.0));
    } else {
      h_2 = (1.046667 * ((
        (r_5 - g_4)
       / tmpvar_13) + 4.0));
    };
  };
  s_1 = 0.0;
  mediump float tmpvar_17;
  tmpvar_17 = ((tmpvar_11 + tmpvar_12) / 2.0);
  if ((tmpvar_13 != 0.0)) {
    s_1 = (tmpvar_13 / (1.0 - abs(
      ((2.0 * tmpvar_17) - 1.0)
    )));
  };
  mediump float tmpvar_18;
  tmpvar_18 = (h_2 - 3.14);
  h_2 = tmpvar_18;
  if ((tmpvar_18 < 0.0)) {
    h_2 = (tmpvar_18 + 6.28);
  };
  mediump float tmpvar_19;
  tmpvar_19 = ((1.0 - abs(
    ((2.0 * tmpvar_17) - 1.0)
  )) * s_1);
  mediump float tmpvar_20;
  tmpvar_20 = ((h_2 / 1.046667) / 2.0);
  mediump float tmpvar_21;
  tmpvar_21 = (fract(abs(tmpvar_20)) * 2.0);
  mediump float tmpvar_22;
  if ((tmpvar_20 >= 0.0)) {
    tmpvar_22 = tmpvar_21;
  } else {
    tmpvar_22 = -(tmpvar_21);
  };
  mediump float tmpvar_23;
  tmpvar_23 = (tmpvar_19 * (1.0 - abs(
    (tmpvar_22 - 1.0)
  )));
  mediump float tmpvar_24;
  tmpvar_24 = (tmpvar_17 - (tmpvar_19 / 2.0));
  mediump float tmpvar_25;
  tmpvar_25 = ((h_2 * 180.0) / 3.14);
  h_2 = tmpvar_25;
  if ((tmpvar_25 < 60.0)) {
    r_5 = tmpvar_19;
    g_4 = tmpvar_23;
    b_3 = 0.0;
  } else {
    if ((tmpvar_25 < 120.0)) {
      r_5 = tmpvar_23;
      g_4 = tmpvar_19;
      b_3 = 0.0;
    } else {
      if ((tmpvar_25 < 180.0)) {
        r_5 = 0.0;
        g_4 = tmpvar_19;
        b_3 = tmpvar_23;
      } else {
        if ((tmpvar_25 < 240.0)) {
          r_5 = 0.0;
          g_4 = tmpvar_23;
          b_3 = tmpvar_19;
        } else {
          if ((tmpvar_25 < 300.0)) {
            r_5 = tmpvar_23;
            g_4 = 0.0;
            b_3 = tmpvar_19;
          } else {
            r_5 = tmpvar_19;
            g_4 = 0.0;
            b_3 = tmpvar_23;
          };
        };
      };
    };
  };
  mediump float tmpvar_26;
  tmpvar_26 = (r_5 + tmpvar_24);
  r_5 = tmpvar_26;
  mediump float tmpvar_27;
  tmpvar_27 = (g_4 + tmpvar_24);
  g_4 = tmpvar_27;
  mediump float tmpvar_28;
  tmpvar_28 = (b_3 + tmpvar_24);
  b_3 = tmpvar_28;
  mediump vec4 tmpvar_29;
  tmpvar_29.x = tmpvar_26;
  tmpvar_29.y = tmpvar_27;
  tmpvar_29.z = tmpvar_28;
  tmpvar_29.w = tmpvar_7.w;
  texcol_6.yzw = tmpvar_29.yzw;
  texcol_6.x = 0.0;
  lowp float x_30;
  x_30 = (texcol_6.w - _Cutoff);
  if ((x_30 < 0.0)) {
    discard;
  };
  highp vec4 tmpvar_31;
  tmpvar_31 = fract((vec4(1.0, 255.0, 65025.0, 1.658138e+07) * min (
    (sqrt(dot (xlv_TEXCOORD0, xlv_TEXCOORD0)) * _LightPositionRange.w)
  , 0.999)));
  highp vec4 tmpvar_32;
  tmpvar_32 = (tmpvar_31 - (tmpvar_31.yzww * 0.003921569));
  gl_FragData[0] = tmpvar_32;
}



#endif"
}
}
Program "fp" {
SubProgram "gles " {
Keywords { "SHADOWS_DEPTH" }
"!!GLES"
}
SubProgram "gles " {
Keywords { "SHADOWS_CUBE" }
"!!GLES"
}
}
 }
}
SubShader { 
 LOD 100
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Cull Off
  Blend One OneMinusSrcAlpha
  ColorMaterial AmbientAndDiffuse
  SetTexture [_MainTex] { combine texture * primary double, texture alpha * primary alpha }
 }
}
}
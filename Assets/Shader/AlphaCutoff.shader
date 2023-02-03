Shader "Sprites/AlphaCutoff" {
Properties {
[PerRendererData]  _MainTex ("Sprite Texture", 2D) = "white" { }
 _Color ("Tint", Color) = (1,1,1,1)
[MaterialToggle]  PixelSnap ("Pixel snap", Float) = 0
 _CutOff ("Cutoff", Range(0,1)) = 0.5
}
SubShader { 
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="true" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="true" }
  ZWrite Off
  Cull Off
  Fog { Mode Off }
  Blend SrcAlpha OneMinusSrcAlpha
  GpuProgramID 42495
Program "vp" {
SubProgram "gles " {
"!!GLES


#ifdef VERTEX

attribute vec4 _glesVertex;
attribute vec4 _glesMultiTexCoord0;
uniform highp mat4 glstate_matrix_mvp;
uniform highp vec4 _MainTex_ST;
varying highp vec2 xlv_TEXCOORD0;
void main ()
{
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = ((_glesMultiTexCoord0.xy * _MainTex_ST.xy) + _MainTex_ST.zw);
}



#endif
#ifdef FRAGMENT

uniform lowp float _CutOff;
uniform lowp vec4 _Color;
uniform sampler2D _MainTex;
varying highp vec2 xlv_TEXCOORD0;
void main ()
{
  highp float a_1;
  lowp float tmpvar_2;
  tmpvar_2 = texture2D (_MainTex, xlv_TEXCOORD0).w;
  a_1 = tmpvar_2;
  lowp vec4 tmpvar_3;
  highp vec2 cse_4;
  cse_4 = (xlv_TEXCOORD0 + vec2(0.01, 0.0));
  tmpvar_3 = texture2D (_MainTex, cse_4);
  lowp vec4 tmpvar_5;
  highp vec2 cse_6;
  cse_6 = (xlv_TEXCOORD0 + vec2(0.0, 0.01));
  tmpvar_5 = texture2D (_MainTex, cse_6);
  lowp vec4 tmpvar_7;
  highp vec2 cse_8;
  cse_8 = (xlv_TEXCOORD0 + vec2(-0.01, 0.0));
  tmpvar_7 = texture2D (_MainTex, cse_8);
  lowp vec4 tmpvar_9;
  highp vec2 cse_10;
  cse_10 = (xlv_TEXCOORD0 + vec2(0.0, -0.01));
  tmpvar_9 = texture2D (_MainTex, cse_10);
  lowp vec4 tmpvar_11;
  highp vec2 cse_12;
  cse_12 = (xlv_TEXCOORD0 + vec2(0.01, 0.01));
  tmpvar_11 = texture2D (_MainTex, cse_12);
  lowp vec4 tmpvar_13;
  highp vec2 cse_14;
  cse_14 = (xlv_TEXCOORD0 + vec2(0.01, -0.01));
  tmpvar_13 = texture2D (_MainTex, cse_14);
  lowp vec4 tmpvar_15;
  highp vec2 cse_16;
  cse_16 = (xlv_TEXCOORD0 + vec2(-0.01, -0.01));
  tmpvar_15 = texture2D (_MainTex, cse_16);
  lowp vec4 tmpvar_17;
  highp vec2 cse_18;
  cse_18 = (xlv_TEXCOORD0 + vec2(-0.01, 0.01));
  tmpvar_17 = texture2D (_MainTex, cse_18);
  highp float tmpvar_19;
  tmpvar_19 = max (max (max (
    max (max (max (max (
      max (a_1, tmpvar_3.w)
    , tmpvar_5.w), tmpvar_7.w), tmpvar_9.w), tmpvar_11.w)
  , tmpvar_13.w), tmpvar_15.w), tmpvar_17.w);
  a_1 = tmpvar_19;
  lowp vec4 tmpvar_20;
  if ((tmpvar_19 > _CutOff)) {
    tmpvar_20 = _Color;
  } else {
    tmpvar_20 = vec4(0.0, 0.0, 0.0, 0.0);
  };
  gl_FragData[0] = tmpvar_20;
}



#endif"
}
}
Program "fp" {
SubProgram "gles " {
"!!GLES"
}
}
 }
}
}
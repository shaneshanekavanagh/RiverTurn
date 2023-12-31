Shader "Alpha/unLit (sep tex)" {

    Properties {

        _Color ("Main Color", Color) = (1,1,1,0.5)

		_MainTex ("Base (RGB)", 2D) = "white" {}

        _AlphaTex ("Trans. (Alpha)", 2D) = "white" {}

    }

 

    Category {

        ZWrite Off

        Alphatest Greater 0

        Tags {Queue=Transparent}

        Blend SrcAlpha OneMinusSrcAlpha 

        ColorMask RGB

        SubShader {

            Material {

                Diffuse [_Color]

            }

            Pass {

                Lighting On

                SeparateSpecular On

                SetTexture [_MainTex] {

                    Combine texture * primary DOUBLE, texture

                } 

                SetTexture [_AlphaTex] {

                    constantColor [_Color]

                    Combine previous, texture * constant 

                } 

            }

        } 

    }

}
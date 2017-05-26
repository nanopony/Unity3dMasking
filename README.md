# Unity3d Sprite Masking demo

![Two separate clipping groups](/Docs/1.png)

Two shaders: ClippingGroup (aka stencil) and ClippedSprite (i.e. what should be clipped). 

Multiple clipping groups are supported, but beware of overlapping. If clipping groups could be overlapped then stencil masking should be used instead, but it will limit amount of indepentent ClippingGroups to 8.


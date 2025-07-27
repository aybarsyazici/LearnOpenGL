#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float mixValue;

void main()
{
    // Zoom in texture1
    vec2 zoomedTexCoord = TexCoord * 0.1 + 0.45;

    FragColor = mix(
        texture(texture1, zoomedTexCoord),                // zoomed-in texture1
        texture(texture2, vec2(-TexCoord.x, TexCoord.y)), // normal texture2 (flipped horizontally)
        mixValue
    );
}

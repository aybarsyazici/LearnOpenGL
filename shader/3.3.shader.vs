#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aColor;

uniform float offsetX;
uniform float offsetY;

out vec3 ourColor;

void main()
{
    gl_Position = vec4(aPos.x + offsetX, aPos.y + offsetY, aPos.z, 1.0);
    ourColor = aColor;
}

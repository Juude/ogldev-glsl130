#version 130

in vec3 Position; 

uniform mat4 gWVP;

void main()
{          
    gl_Position = gWVP * vec4(Position, 1.0);
}

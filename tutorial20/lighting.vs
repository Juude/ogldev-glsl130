#version 130                                                                        
                                                                                    
in vec3 Position;                                             
in vec2 TexCoord;                                             
in vec3 Normal;                                               
                                                                                    
uniform mat4 gWVP;                                                                  
uniform mat4 gWorld;                                                                
                                                                                    
out vec2 TexCoord0;                                                                 
out vec3 Normal0;                                                                   
out vec3 WorldPos0;                                                                 
                                                                                    
void main()                                                                         
{                                                                                   
    gl_Position = gWVP * vec4(Position, 1.0);                                       
    TexCoord0   = TexCoord;                                                         
    Normal0     = (gWorld * vec4(Normal, 0.0)).xyz;                                 
    WorldPos0   = (gWorld * vec4(Position, 1.0)).xyz;                               
}
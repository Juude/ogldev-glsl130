#version 130

in vec2 TexCoord0;
in vec3 Normal0;//this time will use Normal                                                         
                                                                                    
out vec4 FragColor;                                                                 
                                                                                    
struct DirectionalLight                                                             
{                                                                                   
    vec3 Color;                                         
    float AmbientIntensity;
    float DiffuseIntensity;                                                         
    vec3 Direction;                                                         
};                                                                                  
                                                                                    
uniform DirectionalLight gDirectionalLight;                                         
uniform sampler2D gSampler;                                                         
                                                                                    
void main()                                                                         
{                                                                                   
    vec4 AmbientColor = vec4(gDirectionalLight.Color, 1.0f) *                       
                        gDirectionalLight.AmbientIntensity;                         
                                                                                    
    float DiffuseFactor = dot(normalize(Normal0), -gDirectionalLight.Direction);//why is this
                                                                                    
    vec4 DiffuseColor;                                                              
                                                             
    if (DiffuseFactor > 0) {                                  
        DiffuseColor = vec4(gDirectionalLight.Color, 1.0f) *
                       gDirectionalLight.DiffuseIntensity *                        
                       DiffuseFactor;                         
    }                                                                               
    else {                                                                          
        DiffuseColor = vec4(0, 0, 0, 0);                                            
    }                                                                               
                                                                                    
    FragColor = texture2D(gSampler, TexCoord0.xy) *                                 
                (AmbientColor + DiffuseColor);                                      
}

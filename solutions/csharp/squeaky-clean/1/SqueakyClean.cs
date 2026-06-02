public static class Identifier
{
    public static string Clean(string identifier)
    {
        
        String cleanIdentifier = "";
        bool nextUppercase = false;
       
            
        for(int i = 0; i < identifier.Length; i++){

            if(char.IsWhiteSpace(identifier[i])){
                
                cleanIdentifier = cleanIdentifier + '_';
                
            } 
            else if(identifier[i] == '-'){

                cleanIdentifier = cleanIdentifier;
                nextUppercase = true;
                
            }    
            else if(char.IsControl(identifier[i])){
                    
                    cleanIdentifier = cleanIdentifier + "CTRL";
            
            }
            else if (!char.IsLetter(identifier[i])){
                cleanIdentifier = cleanIdentifier;
            }
            else{
                if(nextUppercase){
                    
                    cleanIdentifier = cleanIdentifier + char.ToUpper(identifier[i]);
                    nextUppercase = false;
                }
                else if (identifier[i] >= 'α' && identifier[i] <= 'ω'){  
                    cleanIdentifier = cleanIdentifier;
                    
                } else{
                    cleanIdentifier = cleanIdentifier + identifier[i];
                }
            }
        }
        return cleanIdentifier;
    }
}

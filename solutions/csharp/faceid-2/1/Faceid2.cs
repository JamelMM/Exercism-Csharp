public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object? obj)
    {
        if (obj is FacialFeatures other)
        {
            return other.EyeColor == this.EyeColor && other.PhiltrumWidth == this.PhiltrumWidth;
            
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}   


public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
     public override bool Equals(object? obj)
    {
        if (obj is Identity other)
        {
            return Email == other.Email &&
                   FacialFeatures.Equals(other.FacialFeatures);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    public Identity? registeredIdentity;

    
    Identity admin = new Identity("admin@exerc.ism",new FacialFeatures("green", 0.9m));
    
    
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);


    public bool IsAdmin(Identity identity) => identity.Email == admin.Email
            && identity.FacialFeatures.Equals(admin.FacialFeatures);

    public bool Register(Identity identity)
    {
        if (IsRegistered(identity))
        {
            return false;
        }

        registeredIdentity = identity;
        return true;
    }
    public bool IsRegistered(Identity identity) => registeredIdentity != null && registeredIdentity.Equals(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}

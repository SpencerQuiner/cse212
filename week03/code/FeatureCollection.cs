public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] features {get; set;}
    
}

public class Feature {
    public Earthquake properties {get; set;}
}

public class Earthquake{
    public decimal mag {get; set;}
    public string place {get; set;}

}